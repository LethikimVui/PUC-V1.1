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
    public class LogController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public LogController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost("Log_get")]
        [Obsolete("Use newMethod instead", false)]
        public async Task<List<VLog>> Log_get([FromBody] LogViewModel model)
        {
            var result = await context.Query<VLog>().AsNoTracking().FromSql(SPLog.Log_get, model.MachineId).ToListAsync();
            return result;
        }
        [HttpPost("Log_update")]
        [Obsolete]
        public async Task<IActionResult> Log_update([FromBody] LogViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPLog.Log_update, model.DetailId, model.UsedTimes, model.Message, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
    }
}
