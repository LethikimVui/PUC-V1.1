using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedObjects.Extensions;
using System.DirectoryServices.AccountManagement;
using SharedObjects.ViewModels;

namespace PUC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;
        private readonly ICommonService commonService;

        public AdminController(IAdminService adminService, ICommonService commonService)
        {
            this.adminService = adminService;
            this.commonService = commonService;
        }
        public string GetDisplayNameFromSamAccountName(string samAccountName)
        {
            using (var principalContext = new PrincipalContext(ContextType.Domain))
            {
                try
                {
                    var userPrincipal = UserPrincipal.FindByIdentity(principalContext, samAccountName);
                    if (userPrincipal != null)
                    {
                        return userPrincipal.DisplayName;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    return null;
                }
               
            }
        }
        public async Task<IActionResult> Get()
        {
            var NtLogin = User.GetSpecificClaim("Ntlogin");
            var userRoles = await adminService.Access_UserRole_get();
            ViewData["roles"] = await adminService.Access_Role_get();
            ViewData["customers"] = await commonService.Customer_get(NtLogin);
            return View(userRoles);
        }
        public async Task<IActionResult> Access_UserRole_insert([FromBody] UserRoleViewModel model)
        {
            var result = await adminService.Access_UserRole_insert(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> Access_UserRole_update([FromBody] UserRoleViewModel model)
        {
            var result = await adminService.Access_UserRole_update(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> Access_UserRole_delete([FromBody] UserRoleViewModel model)
        {
            var result = await adminService.Access_UserRole_delete(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> Access_UserRole_Get_By_Id(int id)
        {
            var result = await adminService.Access_UserRole_Get_By_Id(id);
            return Json(new { results = result });
        }
    }
}
