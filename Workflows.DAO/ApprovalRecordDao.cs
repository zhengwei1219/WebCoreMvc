using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Workflows.DAO
{
	internal class ApprovalRecordDao:BaseDao<ApprovalRecord,int>
	{
        WF_IRepository<ApprovalRecord> _approvalRecordRepository;
        WF_IRepository<NHStateMachineInstance> _nHStateMachineInstanceRepository;
        public ApprovalRecordDao(WF_IRepository<ApprovalRecord> approvalRecordRepository, WF_IRepository<NHStateMachineInstance> nHStateMachineInstanceRepository):base(approvalRecordRepository)
        {
            _approvalRecordRepository = approvalRecordRepository;
            _nHStateMachineInstanceRepository = nHStateMachineInstanceRepository;
        }
        internal List<ApprovalRecord> GetRecord(Guid instanceId)
		{
            return _approvalRecordRepository.Table
                   .Where(s => s.WorkflowInstanceId == instanceId)
                  .OrderByDescending(s => s.OperatorTime)
                  .ToList();

		}

		internal List<ApprovalRecord> GetRecord(string workflowName, int eaId)
		{
           var ret = from a in _approvalRecordRepository.Table
                     join b in _nHStateMachineInstanceRepository.Table
                     on a.WorkflowInstanceId equals b.Id
                     where b.WorkflowName == workflowName && a.EaId == eaId
                     select a;
            return ret.ToList();
		}

		internal List<ApprovalRecord> GetRecord(string workflowName, DateTime startDate, DateTime endDate, string userId)
		{
            var ret = from a in _approvalRecordRepository.Table
                      join b in _nHStateMachineInstanceRepository.Table
                      on a.WorkflowInstanceId equals b.Id
                      where b.WorkflowName == workflowName && a.OperatorId == userId && a.OperatorTime>startDate && a.OperatorTime <endDate
                      select a;
            return ret.ToList();

		}

		internal List<ApprovalRecord> GetRecord(string workflowName, DateTime startDate, DateTime endDate, string userId, string unitCode, string roleName)
		{
            var ret = from a in _approvalRecordRepository.Table
                      join b in _nHStateMachineInstanceRepository.Table
                      on a.WorkflowInstanceId equals b.Id
                      where b.WorkflowName == workflowName && a.OperatorUnitCode == unitCode && a.OperatorRole == roleName && a.OperatorId == userId && a.OperatorTime > startDate && a.OperatorTime < endDate
                      select a;
            return ret.ToList();

		}
	}
}
