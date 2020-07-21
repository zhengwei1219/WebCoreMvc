using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
namespace Workflows.DAO
{
	/// <summary>
	/// 基于Nhibernate定制意见的存取.
	/// </summary>
	internal class ApprovalCommentDao :BaseDao<ApprovalComment,int>
	{
        WF_IRepository<ApprovalComment> _approvalCommentDaoRepository;

        public ApprovalCommentDao(WF_IRepository<ApprovalComment> approvalCommentDaoRepository):base(approvalCommentDaoRepository)
        {
            _approvalCommentDaoRepository = approvalCommentDaoRepository;
        }
        /// <summary>
        /// Gets the user comment info.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="approvalType">Type of the approval.</param>
        /// <returns></returns>
        public List<ApprovalComment> GetUserCommentInfo(string userId, string approvalType)
		{
            return _approvalCommentDaoRepository
                   .Table
                   .Where(s => s.OwnerUserId == userId && s.ApprovalType == approvalType)
                   .ToList();
           
		}

		/// <summary>
		/// Gets the comment info.
		/// </summary>
		/// <param name="commentInfo">The comment info.</param>
		/// <param name="userId">The user id.</param>
		/// <param name="approvalType">Type of the approval.</param>
		/// <returns></returns>
		public List<ApprovalComment> GetCommentInfo(string commentInfo, string userId, string approvalType)
		{

            return _approvalCommentDaoRepository
                   .Table
                   .Where(s => s.CommentInfo == commentInfo && s.OwnerUserId == userId && s.ApprovalType == approvalType)
                   .ToList();
            
		}
	}
}
