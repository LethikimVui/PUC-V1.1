using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedObjects.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace PUC.Controllers
{
    ///[Authorize]
    public class CommonController : Controller
    {
        private readonly ICommonService commonService;

        public CommonController(ICommonService commonService)
        {
            this.commonService = commonService;
        }
        public async Task<IActionResult> Main_MachineName_get(int custId)
        {
            var fixtureId = await commonService.Main_MachineName_get(custId);
            return Json(new { result = fixtureId });
        }
        public async Task<IActionResult> Master_Supplier_get()
        {
            var suppliers = await commonService.Master_Supplier_get();
            return Json(new { result = suppliers });
        }
        public async Task<IActionResult> Master_Category_get()
        {
            var categories = await commonService.Master_Category_get();
            return Json(new { result = categories });
        }
    }
}
