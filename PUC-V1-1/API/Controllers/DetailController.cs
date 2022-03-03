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
    }
}
