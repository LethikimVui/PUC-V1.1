using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedObjects.Common;
using SharedObjects.StoredProcedure;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CommonController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet("Customer_Get/{NtLogin}")]
        [Obsolete]
        public async Task<List<VCustomer>> Customer_Get(string NtLogin)
        {
            var results = await context.Query<VCustomer>().AsNoTracking().FromSql(SPCommon.Customer_get, NtLogin).ToListAsync();
            return results;
        }
        [HttpGet("Master_Category_get")]
        [Obsolete()]
        public async Task<List<VCategory>> Master_Category_get()
        {
            var results = await context.Query<VCategory>().AsNoTracking().FromSql(SPCommon.Master_Category_get).ToListAsync();
            return results;
        }
        [HttpPost("Master_Category_insert")]
        [Obsolete()]
        public async Task<IActionResult> Master_Category_insert(CommonViewModel model)
        {
            try
            {
                if (!(context.MasterCategory.Where(x => x.CategoryName == model.CategoryName &&  x.IsActive == 1).ToList().Any()))
                {

                    await context.Database.ExecuteSqlCommandAsync(SPCommon.Master_Category_insert, model.CategoryName, model.Description, model.CreatedBy);
                    return Ok(new ResponseResult(200, "Category added successfully"));
                }
                else
                {
                    return Conflict(new ResponseResult(409, "Category " + model.CategoryName + " already exsiting"));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("Master_Category_delete")]
        [Obsolete]
        public async Task<IActionResult> Master_Category_delete(CommonViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPCommon.Master_Category_delete, model.CategoryId, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpGet("Master_Supplier_get")]
        [Obsolete()]
        public async Task<List<VSupplier>> Master_Supplier_get()
        {
            var results = await context.Query<VSupplier>().AsNoTracking().FromSql(SPCommon.Master_Supplier_get).ToListAsync();
            return results;
        }
        [HttpPost("Master_Supplier_insert")]
        [Obsolete()]
        public async Task<IActionResult> Master_Supplier_insert(CommonViewModel model)
        {
            try
            {
                if (!(context.MasterSupplier.Where(x => x.Supplier == model.Supplier && x.IsActive == 1).ToList().Any()))
                {

                    await context.Database.ExecuteSqlCommandAsync(SPCommon.Master_Supplier_insert, model.Supplier, model.Description, model.CreatedBy);
                    return Ok(new ResponseResult(200, "Supplier added successfully"));
                }
                else
                {
                    return Conflict(new ResponseResult(409, "Supplier " + model.CategoryName + " already exsiting"));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("Master_Supplier_delete")]
        [Obsolete]
        public async Task<IActionResult> Master_Supplier_delete(CommonViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPCommon.Master_Supplier_delete, model.SupplierId, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpGet("Main_MachineName_get/{custId}")]
        [Obsolete()]
        public async Task<List<VMachineName>> Main_MachineName_get(int custId)
        {
            var results = await context.Query<VMachineName>().AsNoTracking().FromSql(SPCommon.Main_MachineName_get, custId).ToListAsync();
            return results;
        }
        [HttpGet("Master_Reason_get")]
        [Obsolete()]
        public async Task<List<VReason>> Reason_Get()
        {
            var results = await context.Query<VReason>().AsNoTracking().FromSql(SPCommon.Master_Reason_get).ToListAsync();
            return results;
        }
        [HttpPost("Master_Reason_insert")]
        [Obsolete()]
        public async Task<IActionResult> Master_Reason_insert(CommonViewModel model)
        {
            try
            {
                if (!(context.MasterReason.Where(x => x.Reason == model.Reason && x.IsActive == 1).ToList().Any()))
                {

                    await context.Database.ExecuteSqlCommandAsync(SPCommon.Master_Reason_insert, model.Reason, model.Description, model.CreatedBy);
                    return Ok(new ResponseResult(200, "Reason added successfully"));
                }
                else
                {
                    return Conflict(new ResponseResult(409, "Reason " + model.Reason + " already exsiting"));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("Master_Reason_delete")]
        [Obsolete]
        public async Task<IActionResult> Master_Reason_delete(CommonViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPCommon.Master_Reason_delete, model.ReasonId, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpGet("Master_Status_get")]
        [Obsolete()]
        public async Task<List<VStatus>> Master_Status_get()
        {
            var results = await context.Query<VStatus>().AsNoTracking().FromSql(SPCommon.Master_Status_get).ToListAsync();
            return results;
        }

    }
}
