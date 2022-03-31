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
    public class DetailController : Controller
    {
        private readonly IDetailService detailService;
        private readonly ICommonService commonService;

        public DetailController(IDetailService detailService, ICommonService commonService)
        {
            this.detailService = detailService;
            this.commonService = commonService;
        }
        public async Task<IActionResult> Get()
        {
            var Ntlogin = User.GetSpecificClaim("Ntlogin");
            ViewData["customers"] = await commonService.Customer_get(Ntlogin);
            var categories = await commonService.Master_Category_get();
            var suppliers = await commonService.Master_Supplier_get();
            ViewData["categories"] = categories;
            ViewData["suppliers"] = suppliers;
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Get_PartialView([FromBody] DetailViewModel model)
        {
            var results = await detailService.Get(model);
            ViewData["reasons"] = await commonService.Master_Reason_Get();
            return PartialView(results);
        }
        public async Task<IActionResult> Detail_Usage_refresh([FromBody] DetailViewModel model)
        {
            var result = await detailService.Detail_Usage_refresh(model);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> Detail_Count([FromBody] DetailViewModel model)
        {
            var count = await detailService.Detail_countpagination(model);
            return Json(new { result = count });
        }
        public async Task<IActionResult> Detail_Get([FromBody] DetailViewModel model)
        {
            var lst = await detailService.Detail_getpagination(model);
            var Ntlogin = User.GetSpecificClaim("Ntlogin");
            ViewData["customers"] = await commonService.Customer_get(Ntlogin);
            var categories = await commonService.Master_Category_get();
            var suppliers = await commonService.Master_Supplier_get();
            ViewData["categories"] = categories;
            ViewData["suppliers"] = suppliers;
            return PartialView(lst);
        }
        public async Task<IActionResult> Detail_add([FromBody] DetailViewModel model)
        {
            var result = await detailService.Detail_Add(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> Detail_Delete([FromBody] DetailViewModel model)
        {
            var result = await detailService.Detail_Delete(model);
            return Json(new { results = result });
        }
    }
}
