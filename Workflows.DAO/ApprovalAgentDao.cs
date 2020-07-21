using System;
using System.Data;
using System.Configuration;
using System.Linq;

using System.Collections.Generic;


namespace Workflows.DAO
{
	/// <summary>
	/// 
	/// </summary>
	internal class ApprovalAgentDao : BaseDao<ApprovalAgent, int>
    {
        WF_IRepository<ApprovalAgent> _aApprovalAgentRepository;

        public ApprovalAgentDao(WF_IRepository<ApprovalAgent> aApprovalAgentRepository):base(aApprovalAgentRepository)
        {
            _aApprovalAgentRepository = aApprovalAgentRepository;
        }

        /// <summary>
        /// Gets the approval agent by user id.
        /// </summary>
        /// <param name="setAgentUserId">The set agent user id.</param>
        /// <returns></returns>
        internal List<ApprovalAgent> GetApprovalAgentByUserId(string setAgentUserId)
		{
            return _aApprovalAgentRepository
                   .Table
                   .Where(a => a.SetUserId == setAgentUserId)
                   .OrderByDescending(a => a.EndDate)
                   .ToList();
		}
		/// <summary>
		/// Gets the valid agent info by to user.
		/// </summary>
		/// <param name="toUserId">To user id.</param>
		/// <returns></returns>
		internal List<ApprovalAgent> GetValidAgentInfoByToUser(string toUserId)
		{
            return _aApprovalAgentRepository.Table
                   .Where(a => a.ToUserId == toUserId && a.BeginDate < DateTime.Now && a.EndDate > DateTime.Now)
                   .OrderByDescending(a => a.EndDate)
                   .ToList();      
		}
		/// <summary>
		/// Gets the agent info by to user.
		/// </summary>
		/// <param name="toUserId">To user id.</param>
		/// <returns></returns>
		internal List<ApprovalAgent> GetAgentInfoByToUser(string toUserId)
		{
            return _aApprovalAgentRepository
                   .Table
                   .Where(a => a.ToUserId == toUserId)
                   .OrderByDescending(a => a.EndDate)
                   .ToList();
            
		}
		/// <summary>
		/// Gets all agent info.
		/// </summary>
		/// <returns></returns>
		internal List<ApprovalAgent> GetAllAgentInfo()
		{
            return _aApprovalAgentRepository
                   .Table
                   .OrderByDescending(a => a.EndDate)
                   .ToList();
        }
	}
}
