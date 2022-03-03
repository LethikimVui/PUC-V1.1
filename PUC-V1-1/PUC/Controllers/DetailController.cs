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
        [AllowAnonymous]
        public async Task<IActionResult> Get([FromBody] DetailViewModel model)
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
    }
}
