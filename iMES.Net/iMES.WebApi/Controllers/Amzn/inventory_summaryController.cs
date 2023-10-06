/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹inventory_summaryController编写
 */

using Microsoft.AspNetCore.Mvc;
using iMES.Core.Controllers.Basic;
using iMES.Entity.AttributeManager;
using iMes.Amzn.IServices;

namespace iMes.Amzn.Controllers
{
    [Route("api/inventory_summary")]
    [PermissionTable(Name = "inventory_summary")]
    public partial class inventory_summaryController : ApiBaseController<IInventorySummaryService>
    {
        public inventory_summaryController(IInventorySummaryService service)
            : base(service)
        {
        }
    }
}