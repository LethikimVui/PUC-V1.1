using Newtonsoft.Json;
using Services.Interfaces;
using SharedObjects.Common;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class LogService : BaseService, ILogService
    {
        public async Task<List<VLog>> Log_get(LogViewModel model)
        {
            var results = new List<VLog>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/log/Log_get", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VLog>>(apiResponse);
            }
            return results;
        }

        public async Task<ResponseResult> Log_update(LogViewModel model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            ResponseResult responseResult = new ResponseResult();
            using (var response = await httpClient.PostAsync("api/log/Log_update", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}
