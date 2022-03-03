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
    public class DetailService : BaseService, IDetailService
    {
        public async Task<ResponseResult> Detail_Usage_refresh(DetailViewModel model)
        {

            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/detail/Detail_Usage_refresh", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VDetail>> Get(DetailViewModel model)
        {

            List<VDetail> list = new List<VDetail>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/detail/Get", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                list = JsonConvert.DeserializeObject<List<VDetail>>(apiResponse);
            }
            return list;
        }
    }
}
