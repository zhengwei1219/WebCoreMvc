using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Workflows.DAO
{
	internal class NHActivityDao :BaseDao<NHActivity,long>
	{
        WF_IRepository<NHActivity> _nHActivityRepository;

        public NHActivityDao(WF_IRepository<NHActivity> nHActivityRepository):base(nHActivityRepository)
        {
            _nHActivityRepository = nHActivityRepository;
        }
        internal List<NHActivity> GetNHActivity(string name)
		{
            return _nHActivityRepository
                   .Table
                   .Where(a => a.TypeName == name)
                   .ToList();
		}

		internal List<NHActivity> GetNHActivity()
		{
            return _nHActivityRepository
                   .Table
                   .ToList();
       
		}

		/// <summary>
		/// Gets the NH activitys.
		/// </summary>
		/// <param name="ids">The ids.</param>
		/// <returns></returns>
		internal List<NHActivity> GetNHActivitys(long[] ids)
		{
            return _nHActivityRepository
                   .Table.Where(s=>ids.Contains(s.Id))
                   .ToList();
       
		}
	}
}
