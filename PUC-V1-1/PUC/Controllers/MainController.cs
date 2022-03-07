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
    public class MainController : Controller
    {
        private readonly IMainService mainService;
        private readonly ICommonService commonService;
        private readonly ILogService logService;

        public MainController(IMainService mainService, ICommonService commonService, ILogService logService)
        {
            this.mainService = mainService;
            this.commonService = commonService;
            this.logService = logService;
        }
        public async Task<IActionResult> Get()
        {
            var Ntlogin = User.GetSpecificClaim("Ntlogin");
            var custId = User.GetSpecificClaim("CustId");
            ViewData["customers"] = await commonService.Customer_get(Ntlogin);
            //ViewData["fixtureId"] = await commonService.Main_MachineName_get(0);

            return View();
        }
        public async Task<IActionResult> Main_Get([FromBody] DetailViewModel model)
        {
            var lst = await mainService.Maintenance_Get(model);
            var Ntlogin = User.GetSpecificClaim("Ntlogin");
            ViewData["customers"] = await commonService.Customer_get(Ntlogin);

            return PartialView(lst);
        }
        public async Task<IActionResult> Maintenance()
        {
            var Ntlogin = User.GetSpecificClaim("Ntlogin");
            var custId = User.GetSpecificClaim("CustId");
            ViewData["customers"] = await commonService.Customer_get(Ntlogin);
            //ViewData["fixtureId"] = await commonService.Main_MachineName_get(0);

            return View();
        }
        public async Task<IActionResult> Maintenance_Get([FromBody] DetailViewModel model)
        {
            var lst = await mainService.Maintenance_Get(model);
            return PartialView(lst);
        }
        public async Task<IActionResult> Main_Count([FromBody] DetailViewModel model)
        {
            var count = await mainService.Main_Count(model);
            return Json(new { result = count });
        }
        public async Task<IActionResult> Add()
        {
            var Ntlogin = User.GetSpecificClaim("Ntlogin");
            var custId = User.GetSpecificClaim("CustId");
            ViewData["customers"] = await commonService.Customer_get(Ntlogin);
            return View();
        }
        public async Task<IActionResult> Delete()
        {
            var Ntlogin = User.GetSpecificClaim("Ntlogin");
            var custId = User.GetSpecificClaim("CustId");
            ViewData["customers"] = await commonService.Customer_get(Ntlogin);
            ViewData["machineName"] = await commonService.Main_MachineName_get(int.Parse(custId));
            return View();
        }
        public async Task<IActionResult> Main_Add([FromBody] DetailViewModel model)
        {
            var result = await mainService.Main_Add(model);
            return Json(new { results = result });
        }  public async Task<IActionResult> Main_Delete([FromBody] DetailViewModel model)
        {
            var result = await mainService.Main_Delete(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> Log_get([FromBody] LogViewModel model)
        {
            var lst = await logService.Log_get(model);
            return PartialView(lst);
        }
        public async Task<IActionResult> Log_update([FromBody] LogViewModel model)
        {
            var result = await logService.Log_update(model);
            return Json(new { statusCode = result.StatusCode });
        }
    }
}
