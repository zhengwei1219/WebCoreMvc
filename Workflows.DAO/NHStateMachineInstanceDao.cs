using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Workflows.DAO
{
	public class NHStateMachineInstanceDao:BaseDao<NHStateMachineInstance,Guid>
	{
        WF_IRepository<NHStateMachineInstance> _nHStateMachineInstanceRepository;

        public NHStateMachineInstanceDao(WF_IRepository<NHStateMachineInstance> nHStateMachineInstanceRepository):base(nHStateMachineInstanceRepository)
        {
            _nHStateMachineInstanceRepository = nHStateMachineInstanceRepository;
        }
        internal List<NHStateMachineInstance> GetInstanceByStateName(string workflowName, string[] stateNames, string typeName)
		{
            return _nHStateMachineInstanceRepository
                   .Table
                   .Where(a => a.WorkflowName == workflowName && a.TypeName == typeName)
                   .Where(a=> stateNames.Contains(a.StateName))
                   .OrderBy(a=>a.StateName)
                   .OrderByDescending(a => a.PersistTime)
                   .ToList();


		}
		internal List<NHStateMachineInstance> GetInstanceById(Guid instanceId)
		{
            return _nHStateMachineInstanceRepository
                   .Table
                   .Where(a => a.Id == instanceId)
                   .OrderByDescending(a => a.PersistTime)
                   .ToList(); 
		}

		internal List<NHStateMachineInstance> GetInstanceByPersisteTime(string workflowName, DateTime startDate, DateTime endDate, string[] stateNames)
		{
            return _nHStateMachineInstanceRepository
                   .Table
                   .Where(a => a.WorkflowName == workflowName && a.PersistTime>startDate && a.PersistTime < endDate || (stateNames!=null && stateNames.Contains(a.StateName)))
                   .OrderBy(a=>a.StateName)
                   .OrderByDescending(a => a.PersistTime)
                   .ToList();
		}

		internal List<NHStateMachineInstance> GetInstanceByPersisteTime(string workflowName, DateTime startDate, DateTime endDate, string[] stateNames, string unitCode)
		{
            var ret = _nHStateMachineInstanceRepository
                   .Table
                   .Where(a => a.WorkflowName == workflowName && a.PersistTime > startDate && a.PersistTime < endDate);

            if (stateNames != null &&  stateNames.Length>0)
            {
                ret = ret.Where(a => stateNames.Contains(a.StateName));
            }
            if(!string.IsNullOrEmpty(unitCode))
            {
                ret = ret.Where(a => a.CreaterUnit.Contains(unitCode));
            }
            return ret
                   .OrderBy(a => a.StateName)
                   .OrderByDescending(a => a.PersistTime)
                   .ToList();

            
		}

		internal List<NHStateMachineInstance> GetUserInstance(string workflowName, string[] stateNames, string unitCode)
		{
            var ret = _nHStateMachineInstanceRepository
                   .Table
                   .Where(a => a.WorkflowName == workflowName);
            if(stateNames != null &&stateNames.Length >0)
            {
                ret.Where(a => stateNames.Contains(a.StateName) && a.CreaterUnit.Contains(unitCode));
            }

            return ret.OrderBy(a => a.StateName)
                      .OrderByDescending(a => a.PersistTime)
                      .ToList();



         
		}

		internal List<NHStateMachineInstance> GetUserInstance(string workflowName, string[] stateNames, string createrUserId, string unitCode)
		{
            var ret = _nHStateMachineInstanceRepository
                   .Table
                   .Where(a => a.WorkflowName == workflowName && a.CreaterUserId == createrUserId);
            if (stateNames != null && stateNames.Length > 0)
            {
                ret.Where(a => stateNames.Contains(a.StateName) && a.CreaterUnit.Contains(unitCode));
            }

            return ret.OrderBy(a => a.StateName)
                      .OrderByDescending(a => a.PersistTime)
                      .ToList();
    
		}

		internal List<NHStateMachineInstance> GetUserInstance(string workflowName, string createrUserId)
		{
            return _nHStateMachineInstanceRepository
                   .Table
                   .Where(a => a.WorkflowName == workflowName && a.CreaterUserId == createrUserId)
                   .OrderByDescending(a => a.PersistTime)
                   .ToList();

		}

		internal List<NHStateMachineInstance> GetUserInstance(string workflowName, int eaId)
		{
            return _nHStateMachineInstanceRepository
                   .Table
                   .Where(a => a.EaId == eaId && a.WorkflowName == workflowName)
                   .OrderByDescending(a => a.PersistTime)
                   .ToList();
		}
	}
}
