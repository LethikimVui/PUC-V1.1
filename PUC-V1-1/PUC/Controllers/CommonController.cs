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
        public async Task<IActionResult> Category()
        {
           var categories = await commonService.Master_Category_get();
            return View(categories);
        }
        public async Task<IActionResult> Supplier()
        {
            var suppliers = await commonService.Master_Supplier_get();
            return View(suppliers);
        }
        public async Task<IActionResult> Reason()
        {
            var reasons = await commonService.Master_Reason_Get();
            return View(reasons);
        }
        public async Task<IActionResult> Master_Reason_insert([FromBody] CommonViewModel model)
        {
            var result = await commonService.Master_Reason_insert(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> Master_Reason_delete([FromBody] CommonViewModel model)
        {
            var result = await commonService.Master_Reason_delete(model);
            return Json(new { results = result });
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
        public async Task<IActionResult> Master_Category_insert([FromBody] CommonViewModel model)
        {
            var result = await commonService.Master_Category_insert(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> Master_Category_delete([FromBody] CommonViewModel model)
        {
            var result = await commonService.Master_Category_delete(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> Master_Supplier_insert([FromBody] CommonViewModel model)
        {
            var result = await commonService.Master_Supplier_insert(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> Master_Supplier_delete([FromBody] CommonViewModel model)
        {
            var result = await commonService.Master_Supplier_delete(model);
            return Json(new { results = result });
        }
    }
}
