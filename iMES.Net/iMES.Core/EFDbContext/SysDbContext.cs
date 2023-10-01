﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using iMES.Core.DBManager;
using iMES.Core.Extensions.AutofacManager;
using iMES.Entity.SystemModels;

namespace iMES.Core.EFDbContext
{
    public class SysDbContext : BaseDbContext, IDependency
    {
        protected override string ConnectionString
        {
            get { return DBServerProvider.SysConnectingString; }
        }

        public SysDbContext() : base()
        {
        }

        public SysDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Console.WriteLine("db con str:" + ConnectionString);
            base.UseDbType(optionsBuilder, ConnectionString);
            //默认禁用实体跟踪
            optionsBuilder = optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder, typeof(SysEntity));
        }
    }
}