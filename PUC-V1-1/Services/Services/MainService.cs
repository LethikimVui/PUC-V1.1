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
    public class MainService : BaseService, IMainService
    {
        public async Task<int> Main_Count(DetailViewModel model)
        {
            int count = 0;
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/main/Main_Count", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                count = JsonConvert.DeserializeObject<int>(apiResponse);
            }
            return count;
        }

        public async Task<List<VMain>> Maintenance_Get(DetailViewModel model)
        {
            List<VMain> list = new List<VMain>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/main/Maintenance_Get", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                list = JsonConvert.DeserializeObject<List<VMain>>(apiResponse);
            }
            return list;
        }

        public async Task<ResponseResult> Main_Add(DetailViewModel model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            ResponseResult responseResult = new ResponseResult();
            using (var response = await httpClient.PostAsync("api/main/Main_Add", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> Main_Delete(DetailViewModel model)
        {
          StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            ResponseResult responseResult = new ResponseResult();
            using (var response = await httpClient.PostAsync("api/main/Main_Delete", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}
