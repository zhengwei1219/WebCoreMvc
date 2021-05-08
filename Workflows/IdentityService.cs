using System;
using System.Web;
using System.Collections.Generic;
using System.Text;
using BLL;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Model;

namespace Workflows
{
	/// <summary>
	/// �û�����ṩ����
	/// </summary>
	public interface IIdentityService
	{
		/// <summary>
		/// Gets all users.
		/// </summary>
		/// <returns></returns>
		string[] GetAllUsers();
		/// <summary>
		/// Gets the user identity.
		/// </summary>
		/// <returns></returns>
		IUserIdentity GetUserIdentity();
		/// <summary>
		/// Gets the user identity.
		/// </summary>
		/// <param name="userId">The user id.</param>
		/// <returns></returns>
		IUserIdentity GetUserIdentity(string userId);
		/// <summary>
		/// Gets the user in role.
		/// </summary>
		/// <returns></returns>
		IUserInRole GetUserInRole();
		/// <summary>
		///ˢ�»���
		/// </summary>
		/// <param name="userId">�û���</param>
		void FlushCache(string userId);
	}

	/// <summary>
	/// ����HttpContent������ṩ�߷���
	/// </summary>
	public class HttpIdentityService : IIdentityService
	{
        ISysUserService _userService;
        IHttpContextAccessor _httpContextAccessor;
        public HttpIdentityService(ISysUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }
        #region IIdentityService Members
        private Dictionary<string, IdentitiyCache> identityCache = new Dictionary<string, IdentitiyCache>();

		/// <summary>
		/// Gets all users.
		/// </summary>
		/// <returns></returns>
		public string[] GetAllUsers()
		{
            return  _userService.GetAll().Select(s => s.Name).ToArray();
			//List<string> users = new List<string>();
			//MembershipUserCollection mUsers = Membership.GetAllUsers();
			//foreach (MembershipUser user in mUsers)
			//{
			//	users.Add(user.UserName);
			//}
			//return users.ToArray();
		}

		/// <summary>
		/// Gets the user identity.
		/// </summary>
		/// <returns></returns>
		public IUserIdentity GetUserIdentity()
		{
            return GetUserIdentity(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            //return GetUserIdentity(HttpContext.Current.User.Identity.Name);
        }

		/// <summary>
		/// �����û���ID��ȡ�û��������Ϣ,���userIdΪ��,��ô����null
		/// </summary>
		/// <param name="userId">The user id.</param>
		/// <returns></returns>
		public IUserIdentity GetUserIdentity(string userId)
		{
			if (string.IsNullOrEmpty(userId))
				return null;
			if (!identityCache.ContainsKey(userId) || identityCache[userId].TimeStamp.AddMinutes(cacheDuration) <= DateTime.Now)
				LoadIdentity(userId);
			return identityCache[userId].UserIdentity;
		}

		/// <summary>
		/// Loads the identity.
		/// </summary>
		/// <param name="userId">The user id.</param>
		private void LoadIdentity(string userId)
		{
           SysUser user = _userService.getByAccount(userId);
            HttpUserIdentity identity = new HttpUserIdentity(userId, user.Name, user.Email,user);
            identityCache[userId] = new IdentitiyCache(identity);
            //         ProfileBase profile = ProfileBase.Create(userId);
            //string userName = profile.GetPropertyValue("Name").ToString();
            //string unitCode = profile.GetPropertyValue("UnitCode").ToString();
            //HttpUserIdentity identity = new HttpUserIdentity(userId, userName, unitCode, profile);
            //identityCache[userId] = new IdentitiyCache(identity);
        }
		private HttpUserInRole userInRole = HttpUserInRole.Instance;
		/// <summary>
		/// Gets the user in role.
		/// </summary>
		/// <returns></returns>
		public IUserInRole GetUserInRole()
		{
			return this.userInRole;
		}
		/// <summary>
		/// ˢ�»���
		/// </summary>
		/// <param name="userId">�û���</param>
		public void FlushCache(string userId)
		{
			if (string.IsNullOrEmpty(userId))
				throw new ArgumentNullException("userId");
			userInRole.Flush(userId);
			LoadIdentity(userId);
		}
		private int cacheDuration = 30;
		/// <summary>
		/// Sets the duration of the cache.
		/// </summary>
		/// <value>The duration of the cache.</value>
		public int CacheDuration
		{
			set
			{
				if (value > 0)
				{
					this.cacheDuration = value;
					userInRole.CacheDuration = value;
				}
			}
		}

		#endregion

		/// <summary>
		/// 
		/// </summary>
		private class IdentitiyCache
		{
			/// <summary>
			/// Initializes a new instance of the <see cref="IdentitiyCache"/> class.
			/// </summary>
			/// <param name="identity">The identity.</param>
			public IdentitiyCache(HttpUserIdentity identity)
			{
				this.userIdentity = identity;
				this.timeStamp = DateTime.Now;
			}
			private HttpUserIdentity userIdentity;
			/// <summary>
			/// Gets the user identity.
			/// </summary>
			/// <value>The user identity.</value>
			public HttpUserIdentity UserIdentity
			{
				get { return this.userIdentity; }
			}
			private DateTime timeStamp;
			/// <summary>
			/// Gets the time stamp.
			/// </summary>
			/// <value>The time stamp.</value>
			public DateTime TimeStamp
			{
				get { return this.timeStamp; }
			}
		}
	}
}
