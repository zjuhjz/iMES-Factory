using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using iMES.Core.DBManager;
using iMES.Core.Extensions.AutofacManager;
using iMES.Entity.SystemModels;
using iMES.Entity.DomainModels;

namespace iMES.Core.EFDbContext
{
    public class ReportDbContext : BaseDbContext, IDependency
    {
        protected override string ConnectionString
        {
            get { return DBServerProvider.ReportConnectingString; }
        }

        public ReportDbContext() : base()
        {
        }

        public ReportDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.UseDbType(optionsBuilder, ConnectionString);
            //默认禁用实体跟踪
            optionsBuilder = optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InventorySummary>().ToTable("inventory_summary");

            base.OnModelCreating(modelBuilder, typeof(ReportEntity));
        }
    }
}