using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
    public class DetailController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public DetailController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost("Get")]
        [Obsolete("Use newMethod instead", false)]
        public async Task<List<VDetail>> Get([FromBody] DetailViewModel model)
        {
            var result = await context.Query<VDetail>().AsNoTracking().FromSql(SPDetail.Detail_get, model.MachineId, model.DetailId).ToListAsync();
            return result;
        }
        [HttpPost("Detail_Usage_refresh")]
        [Obsolete]
        public async Task<IActionResult> Detail_Usage_refresh([FromBody] DetailViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDetail.Detail_Usage_refresh, model.strDetailId, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("Detail_Add")]
        [Obsolete("Use newMethod instead", false)]
        public async Task<IActionResult> Detail_Add([FromBody] DetailViewModel model)
        {
            try
            {
                if (!(context.Detail.Where(x => x.Location == model.Location && x.PartNumber == model.PartNumber).ToList().Any()))
                {

                    await context.Database.ExecuteSqlCommandAsync(SPDetail.Detail_Add, model.MachineId, model.SupplierId, model.CategoryId, model.PartNumber, model.Location, model.Limit, model.CustomLimit, model.TriggerLimit, model.Description, model.CreatedBy);
                    return Ok(new ResponseResult(200, "Location added successfully"));
                }
                else
                {
                    return Conflict(new ResponseResult(409, "Location " + model.Location + " already exsiting"));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("Detail_getpagination")]
        [Obsolete]
        public async Task<List<VDetail>> Detail_getpagination([FromBody] DetailViewModel model)
        {
            var result = await context.Query<VDetail>().AsNoTracking().FromSql(SPDetail.Detail_getpagination, model.PageIndex, model.PageSize, model.CustId, model.CategoryId, model.SupplierId, model.MachineId, model.PartNumber, model.Location).ToListAsync();
            return result;
        }
        [HttpPost("Detail_countpagination")]
        [Obsolete("Use newMethod instead", false)]
        public async Task<int> Detail_countpagination([FromBody] DetailViewModel model)
        {
            var output = new SqlParameter
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.Output
            };
            await context.Database.ExecuteSqlCommandAsync(SPDetail.Detail_countpagination, model.CustId, model.CategoryId, model.SupplierId, model.MachineId, model.PartNumber, model.Location, output);
            var result = (int)output.Value;
            return result;
        }
        [HttpPost("Detail_Delete")]
        [Obsolete("Use newMethod instead", false)]
        public async Task<IActionResult> Detail_Delete([FromBody] DetailViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDetail.Detail_Delete, model.DetailId, model.UpdatedBy);
                return Ok(new ResponseResult(200, "Location deleted successfully"));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
    }
}
