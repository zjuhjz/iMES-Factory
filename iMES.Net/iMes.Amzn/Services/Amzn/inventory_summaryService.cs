/*
 *Author：COCO
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下inventory_summaryService与Iinventory_summaryService中编写
 */

using iMes.Amzn.IRepositories;
using iMes.Amzn.IServices;
using iMES.Core.BaseProvider;
using iMES.Core.Extensions.AutofacManager;
using iMES.Entity.DomainModels;

namespace iMes.Amzn.Services
{
    public partial class inventory_summaryService : ServiceBase<InventorySummary, IInventorySummaryRepository>
        , IInventorySummaryService, IDependency
    {
        public inventory_summaryService(IInventorySummaryRepository repository)
            : base(repository)
        {
            Init(repository);
        }

        public static IInventorySummaryService Instance
        {
            get { return AutofacContainerModule.GetService<IInventorySummaryService>(); }
        }
    }
}