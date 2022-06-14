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
    public class RequestService : BaseService, IRequestService

    {
        public async Task<ResponseResult> Request_Approve(RequestViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/Request/Request_Approve", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VRequestDetail>> Request_Detail(RequestViewModel model)
        {
            List<VRequestDetail> results = new List<VRequestDetail>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            using (var response = await httpClient.PostAsync("api/Request/Request_Detail", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VRequestDetail>>(apiResponse);
            }
            return results;
        }

        public async Task<List<VRequest>> Request_Get(RequestViewModel model)
        {
            List<VRequest> results = new List<VRequest>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            using (var response = await httpClient.PostAsync("api/Request/Request_Get", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VRequest>>(apiResponse);
            }
            return results;
        }

        public async Task<List<VApproval>> Request_Get_Approval(RequestViewModel model)
        {
            List<VApproval> results = new List<VApproval>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            using (var response = await httpClient.PostAsync("api/Request/Request_Get_Approval", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VApproval>>(apiResponse);
            }
            return results;
        }

        public async Task<ResponseResult> Request_insert(RequestViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/Request/Request_insert", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> Request_Reject(RequestViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/Request/Request_Reject", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}
