using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Workflows.DAO
{
	internal class ApprovalAssignmentDao : BaseDao<ApprovalAssignment, int>
    {
        WF_IRepository<NHStateMachineInstance> _nHStateMachineInstanceRepository;
        WF_IRepository<ApprovalAssignment> _approvalAssignmentRepository;

        public ApprovalAssignmentDao(WF_IRepository<ApprovalAssignment> approvalAssignmentRepository, WF_IRepository<NHStateMachineInstance> nHStateMachineInstanceRepository):base(approvalAssignmentRepository)
        {
            _nHStateMachineInstanceRepository = nHStateMachineInstanceRepository;
            _approvalAssignmentRepository = approvalAssignmentRepository;
        }
        internal List<ApprovalAssignment> GetAssignmentByAssignedRole(string workflowName, string toRoleName, Guid instanceId, string assignState)
		{
			StringBuilder queryHQL = new StringBuilder();
			queryHQL.Append("select assignment from WF_ApprovalAssignment as assignment, NHStateMachineInstance as instance where assignment.WorkflowInstanceId=instance.Id and instance.WorkflowName={3}");
			queryHQL.Append(" and assignment.WorkflowInstanceId={0}");
			queryHQL.Append(" and assignment.ToRole={1}");
			queryHQL.Append(" and assignment.AssignState={2}");
            var parameter = new object[1];
            parameter[0] = instanceId;

            parameter[1] = toRoleName;
            parameter[2] = assignState;
            parameter[3] = workflowName;
           return  _approvalAssignmentRepository.ExcuteQuery(queryHQL.ToString(), parameter)
                                        .ToList() ;

		}

		internal List<ApprovalAssignment> GetAssignmentByAssignedRole(string toRoleName, InstanceCollection instances)
		{
            var ret = from a in _approvalAssignmentRepository.Table
                      join b in _nHStateMachineInstanceRepository.Table
                      on a.WorkflowInstanceId equals b.Id
                      where a.ToRole == toRoleName
                      select a;
            return ret.ToList();



   //         StringBuilder queryHQL = new StringBuilder();
			//queryHQL.Append("select assignment from " + persitentType.Name + " as assignment, NHStateMachineInstance as instance where");
			//queryHQL.Append(" assignment.WorkflowInstanceId=instance.Id and assignment.ToRole='" + toRoleName + "'");

			//StringBuilder temp = new StringBuilder();
			//for (int i = 0; i < instances.Count; i++)
			//{
			//	if (temp.Length > 0)
			//		temp.Append(" or ");
			//	temp.Append("(   instance.WorkflowName='" + instances[i].Instance.WorkflowName + "'");
			//	temp.Append(" and assignment.WorkflowInstanceId='" + instances[i].Instance.Id + "'");
			//	temp.Append(" and assignment.AssignState='" + instances[i].Instance.StateName + "')");
			//}
			//if (temp.Length > 0)
			//	queryHQL.AppendFormat(" and ({0})", temp.ToString());
			//return ConvertToGenericList(session.CreateQuery(queryHQL.ToString()).List());
		}


		internal List<ApprovalAssignment> GetAssignmentByAssignState(Guid instanceId, string assignState)
		{
            return _approvalAssignmentRepository.Table
                   .Where(s => s.WorkflowInstanceId == instanceId && s.AssignState == assignState)
                   .ToList();
		}

		internal List<ApprovalAssignment> GetAssignmentByUserId(string workflowName, string assignToUserId)
		{
            var ret = from a in _approvalAssignmentRepository.Table
                      join b in _nHStateMachineInstanceRepository.Table
                      on a.WorkflowInstanceId equals b.Id
                      where b.WorkflowName == workflowName
                      select a;
            return ret.ToList();

		}

		internal List<ApprovalAssignment> GetAssignmentByToUnit(string workflowName, string unitCode)
		{
            var ret = from a in _approvalAssignmentRepository.Table
                      join b in _nHStateMachineInstanceRepository.Table
                      on a.WorkflowInstanceId equals b.Id
                      where b.WorkflowName == workflowName && a.ToUnitCode == unitCode
                      select a;
            return ret.ToList();
        }

		internal List<ApprovalAssignment> GetAssignment(Guid instanceId)
		{
            return _approvalAssignmentRepository.Table
                   .Where(s => s.WorkflowInstanceId == instanceId)
                   .ToList();

		}

		internal List<ApprovalAssignment> GetAssignment(Guid[] instanceIDs)
		{
            return _approvalAssignmentRepository.Table
                   .Where(s => instanceIDs.Contains(s.WorkflowInstanceId))
                   .ToList();
		}

		internal List<ApprovalAssignment> GetAssignment(string workflowName, int eaId)
		{
            var ret = from a in _approvalAssignmentRepository.Table
                      join b in _nHStateMachineInstanceRepository.Table
                      on a.WorkflowInstanceId equals b.Id
                      where a.EaId == eaId && b.WorkflowName == workflowName
                      select a;
            return ret.ToList();

		}
	}
}
