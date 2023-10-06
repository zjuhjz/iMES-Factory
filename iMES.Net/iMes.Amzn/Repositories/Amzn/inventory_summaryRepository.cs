/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹inventory_summaryRepository编写代码
 */

using iMes.Amzn.IRepositories;
using iMES.Core.BaseProvider;
using iMES.Core.EFDbContext;
using iMES.Core.Extensions.AutofacManager;
using iMES.Entity.DomainModels;

namespace iMes.Amzn.Repositories
{
    public partial class InventorySummaryRepository : RepositoryBase<InventorySummary>, IInventorySummaryRepository
    {
        public InventorySummaryRepository(SysDbContext dbContext)
            : base(dbContext)
        {
        }

        public static IInventorySummaryRepository Instance
        {
            get { return AutofacContainerModule.GetService<IInventorySummaryRepository>(); }
        }
    }
}