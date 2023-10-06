/*
 *接口编写处...
 *如果接口需要做Action的权限验证，请在Action上使用属性
 *如: [ApiActionPermission("inventory_summary",Enums.ActionPermissionOptions.Search)]
 */

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using iMES.Entity.DomainModels;
using iMes.Amzn.IServices;

namespace iMes.Amzn.Controllers
{
    public partial class inventory_summaryController
    {
        private readonly IInventorySummaryService _service; //访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public inventory_summaryController(
            IInventorySummaryService service,
            IHttpContextAccessor httpContextAccessor
        )
            : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
    }
}