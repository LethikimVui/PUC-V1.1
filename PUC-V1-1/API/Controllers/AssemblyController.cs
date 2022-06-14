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
    public class AssemblyController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AssemblyController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost("Master_Assembly_get")]
        [Obsolete]
        public async Task<List<VAssembly>> Master_Assembly_get([FromBody] AssemblyViewModel model)
        {
            var results = await context.Query<VAssembly>().AsNoTracking().FromSql(SPAssembly.Master_Assembly_get, model.PageIndex, model.PageSize, model.CustId, model.MachineId, model.AssemblyNo).ToListAsync();
            return results;
        }
        [HttpPost("Master_Assembly_count")]
        [Obsolete("Use newMethod instead", false)]
        public async Task<int> Master_Assembly_count([FromBody] AssemblyViewModel model)
        {
            var output = new SqlParameter
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.Output
            };
            await context.Database.ExecuteSqlCommandAsync(SPAssembly.Master_Assembly_count, model.CustId, model.MachineId, model.AssemblyNo, output);
            var result = (int)output.Value;
            return result;
        }
        [HttpPost("Master_Assembly_delete")]
        [Obsolete]
        public async Task<IActionResult> Master_Assembly_delete([FromBody] AssemblyViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPAssembly.Master_Assembly_delete, model.AssemblyId, model.UpdatedBy);
                return Ok(new ResponseResult(200, model.AssemblyNo + " is deleted"));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }

        }
        [HttpPost("Master_Assembly_update")]
        [Obsolete]
        public async Task<IActionResult> Master_Assembly_update([FromBody] AssemblyViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPAssembly.Master_Assembly_update, model.AssemblyId, model.AssemblyNo, model.UpdatedBy);
                return Ok(new ResponseResult(200, "updated successfully"));
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
    }
}
