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
        /// ����һ������
        /// </summary>
        public void BeginTransaction()
		{
            _dbContext.Database.BeginTransaction();
        }

		/// <summary>
		/// �ύ����
		/// </summary>
		public void CommitTransaction()
		{
            _dbContext.Database.CommitTransaction();
		}

		/// <summary>
		/// ��������
		/// </summary>
		public void RollbackTransaction()
		{
            _dbContext.Database.RollbackTransaction();
		}

		#endregion
	}
}
