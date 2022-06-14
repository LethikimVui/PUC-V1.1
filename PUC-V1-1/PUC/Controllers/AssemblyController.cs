using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Services.Interfaces;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using SharedObjects.Extensions;

namespace PUC.Controllers
{
    public class AssemblyController : Controller
    {
        private readonly IAssemblyService assemblyService;
        private readonly ICommonService commonService;

        public AssemblyController(IAssemblyService assemblyService, ICommonService commonService)
        {
            this.assemblyService = assemblyService;
            this.commonService = commonService;
        }

        public async Task<IActionResult> Get()
        {
            var Ntlogin = User.GetSpecificClaim("Ntlogin");
            ViewData["customers"] = await commonService.Customer_get(Ntlogin);
            //var results = await assemblyService.Master_Assembly_get();
            return View();
        }
        public async Task<IActionResult> Assembly_Count([FromBody] AssemblyViewModel model)
        {
            var count = await assemblyService.Master_Assembly_count(model);
            return Json(new { result = count });
        }
        public async Task<IActionResult> Assembly_Get([FromBody] AssemblyViewModel model)
        {
            var results = await assemblyService.Master_Assembly_get(model);
            var Ntlogin = User.GetSpecificClaim("Ntlogin");
            ViewData["customers"] = await commonService.Customer_get(Ntlogin);
            var categories = await commonService.Master_Category_get();
            var suppliers = await commonService.Master_Supplier_get();
            ViewData["categories"] = categories;
            ViewData["suppliers"] = suppliers;
            return PartialView(results);
        }
        public async Task<IActionResult> Master_Assembly_delete([FromBody] AssemblyViewModel model)
        {
            var results = await assemblyService.Master_Assembly_delete(model);
            return Json(new { results = results });
        }
        public async Task<IActionResult> Master_Assembly_update(AssemblyViewModel model)
        {
            var results = await assemblyService.Master_Assembly_update(model);
            return Json(new { results = results });
        }


    }
}
