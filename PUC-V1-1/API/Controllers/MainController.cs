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
    public class MainController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public MainController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost("Main_Get")]
        [Obsolete("Use newMethod instead", false)]
        public async Task<List<VMain>> GetPagination([FromBody] DetailViewModel model)
        {

            var results = await context.Query<VMain>().AsNoTracking().FromSql(SPMain.Main_get, model.PageIndex, model.PageSize, model.strCustId, model.strMachineId, model.SerialNumber, model.PartNumber, model.Description).ToListAsync();

            return results;
        }

        [HttpPost("Main_Count")]
        [Obsolete("Use newMethod instead", false)]
        public async Task<int> CountPagination([FromBody] DetailViewModel model)
        {
            var results = await context.Query<VCount>().AsNoTracking().FromSql(SPMain.Main_Count, model.strCustId, model.strMachineId, model.SerialNumber, model.PartNumber, model.Description).ToListAsync();
            int count = (int)results[0].Count;
            return count;
        }
        [HttpPost("Main_Add")]
        [Obsolete("Use newMethod instead", false)]
        public async Task<IActionResult> Main_Add([FromBody] DetailViewModel model)
        {
            try
            {
                if (!(context.Main.Where(x => x.MachineId == model.MachineId).ToList().Any()))
                {

                    await context.Database.ExecuteSqlCommandAsync(SPMain.Main_Add, model.CustId, model.MachineId, model.SerialNumber, model.PartNumber, model.Description, model.CreatedBy);
                    return Ok(new ResponseResult(200, "Machine added successfully"));
                }
                else
                {
                    return Conflict(new ResponseResult(409, "Machine " + model.MachineName + " already exsiting"));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
    }
}
