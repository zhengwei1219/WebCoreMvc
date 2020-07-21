using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;


namespace Workflows.DAO
{

	/// <summary>
	/// 
	/// </summary>
	public class NHTransactionService : ITransactionService
	{
        private WF_GeneralDbContext _dbContext;
        public NHTransactionService(WF_GeneralDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #region ITransactionService Members

        /// <summary>
        /// 开启一个事务
        /// </summary>
        public void BeginTransaction()
		{
            _dbContext.Database.BeginTransaction();
        }

		/// <summary>
		/// 提交事务
		/// </summary>
		public void CommitTransaction()
		{
            _dbContext.Database.CommitTransaction();
		}

		/// <summary>
		/// 滚回事务
		/// </summary>
		public void RollbackTransaction()
		{
            _dbContext.Database.RollbackTransaction();
		}

		#endregion
	}
}
