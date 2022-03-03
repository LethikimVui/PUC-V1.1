using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedObjects.StoredProcedure;
using SharedObjects.ValueObjects;
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
        [HttpGet("Master_Supplier_get")]
        [Obsolete()]
        public async Task<List<VSupplier>> Supplier_select()
        {
            var results = await context.Query<VSupplier>().AsNoTracking().FromSql(SPCommon.Master_Supplier_get).ToListAsync();
            return results;
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
        [HttpGet("Master_Status_get")]
        [Obsolete()]
        public async Task<List<VStatus>> Master_Status_get()
        {
            var results = await context.Query<VStatus>().AsNoTracking().FromSql(SPCommon.Master_Status_get).ToListAsync();
            return results;
        }
    }
}
