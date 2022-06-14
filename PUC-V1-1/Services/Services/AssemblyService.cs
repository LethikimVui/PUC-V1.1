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
    public class AssemblyService : BaseService, IAssemblyService
    {
        public async Task<int> Master_Assembly_count(AssemblyViewModel model)
        {
            int count = 0;
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/Assembly/Master_Assembly_count", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                count = JsonConvert.DeserializeObject<int>(apiResponse);
            }
            return count;
        }

        public async Task<ResponseResult> Master_Assembly_delete(AssemblyViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/Assembly/Master_Assembly_delete", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VAssembly>> Master_Assembly_get(AssemblyViewModel model)
        {
            var results = new List<VAssembly>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/Assembly/Master_Assembly_get", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VAssembly>>(apiResponse);
            }
            return results;           
        }

        public async Task<ResponseResult> Master_Assembly_update(AssemblyViewModel model)
        {
            var responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/Assembly/Master_Assembly_update", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}
