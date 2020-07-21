using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workflows.DAO
{
    public class WF_GeneralDbContext: DbContext
    {
        public WF_GeneralDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ApprovalAgent> ApprovalAgents { get; set; }
        public DbSet<ApprovalComment> ApprovalComments { get; set; }
        public DbSet<ApprovalRecord> ApprovalRecords { get; set; }
        public DbSet<ApprovalSolution> ApprovalSolutions { get; set; }
        public DbSet<EaAuditLog> EaAuditLogs { get; set; }
        public DbSet<NHActivity> NHActivitys { get; set; }
        public DbSet<NHStateMachineInstance> NHStateMachineInstances { get; set; }

    }
}
