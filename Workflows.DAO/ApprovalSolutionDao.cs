using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Workflows.DAO
{
   
    internal class ApprovalSolutionDao :BaseDao<ApprovalSolution,int>
	{
        WF_IRepository<ApprovalSolution> _approvalSolutionRepository;
        WF_IRepository<NHStateMachineInstance> _nHStateMachineInstanceRepository;
        public ApprovalSolutionDao(WF_IRepository<ApprovalSolution> approvalSolutionRepository, WF_IRepository<NHStateMachineInstance> nHStateMachineInstanceRepository):base(approvalSolutionRepository)
        {
            _nHStateMachineInstanceRepository = nHStateMachineInstanceRepository;
            _approvalSolutionRepository = approvalSolutionRepository;
        }
        internal List<ApprovalSolution> GetSolution(Guid instanceId)
		{
           return _approvalSolutionRepository.Table
                .Where(s => s.WorkflowInstanceId == instanceId)
                .OrderByDescending(s => s.OperatorTime)
                .ToList();
		}

		internal List<ApprovalSolution> GetSolution(string workflowName, int eaId)
		{
            var ret =from a in _approvalSolutionRepository.Table
            join b in _nHStateMachineInstanceRepository.Table
            on a.WorkflowInstanceId equals b.Id
            where a.EaId == eaId && b.WorkflowName == workflowName
            select a;
            return ret.ToList();

		}
	}
}