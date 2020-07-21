using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Workflows.DAO
{
	/// <summary>
	/// 
	/// </summary>
	public class EaAuditLogDao :BaseDao<EaAuditLog,int>
	{
        WF_IRepository<EaAuditLog> _eaAuditLogRepository;

        public EaAuditLogDao(WF_IRepository<EaAuditLog> eaAuditLogRepository):base(eaAuditLogRepository)
        {
            _eaAuditLogRepository = eaAuditLogRepository;
        }
        /// <summary>
        /// Gets the audit log by ea id.
        /// </summary>
        /// <param name="eaId">The ea id.</param>
        /// <returns></returns>
        public List<EaAuditLog> GetAuditLogByEaId(int eaId)
		{
            return _eaAuditLogRepository
                  .Table
                  .Where(a => a.ClassName == "БўПо" && a.EaId == eaId)
                  .OrderByDescending(a => a.UpdateTime)
                  .ToList();

		}
	}
}
