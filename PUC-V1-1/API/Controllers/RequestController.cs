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
    public class RequestController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public RequestController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost("Request_Get")]
        [Obsolete("Use newMethod instead", false)]
        public async Task<List<VRequest>> Request_Get([FromBody] RequestViewModel model)
        {
            var result = await context.Query<VRequest>().AsNoTracking().FromSql(SPRequest.Request_Get, model.StatusId).ToListAsync();
            return result;
        }

        [HttpPost("Request_insert")]
        [Obsolete]
        public async Task<IActionResult> Request_insert([FromBody] RequestViewModel model)
        {
            try
            {
                var results = await context.Query<VTicket>().AsNoTracking().FromSql(SPRequest.Request_insert, model.DetailId, model.CategoryId, model.SupplierId, model.Location, model.PartNumber, model.Limit, model.TriggerLimit, model.CreatedBy, model.Description, model.FileName).ToListAsync();
                var ticket = (string)results[0].Ticket;
                return Ok(new ResponseResult(200, "Request " + ticket + " is submited successfully"));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }

        [HttpPost("Request_Detail")]
        [Obsolete("Use newMethod instead", false)]
        public async Task<List<VRequestDetail>> Request_Detail([FromBody] RequestViewModel model)
        {
            var result = await context.Query<VRequestDetail>().AsNoTracking().FromSql(SPRequest.Request_Detail, model.ReqId).ToListAsync();
            return result;
        }
        [HttpPost("Request_Reject")]
        [Obsolete]
        public async Task<IActionResult> Request_Reject([FromBody] RequestViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPRequest.Request_Reject, model.ReqId, model.Description, model.UpdatedBy);
                return Ok(new ResponseResult(200, "Request is rejected"));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        } 
        [HttpPost("Request_Approve")]
        [Obsolete]
        public async Task<IActionResult> Request_Approve([FromBody] RequestViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPRequest.Request_Approve, model.ReqId, model.Description, model.UpdatedBy);
                return Ok(new ResponseResult(200, "Request is approved"));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
    }
}
