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
    public class CommonService : BaseService, ICommonService
    {
        public async Task<List<VCustomer>> Customer_get(string NtLogin)
        {
            List<VCustomer> customers = new List<VCustomer>();

            using (var response = await httpClient.GetAsync("api/common/Customer_Get/" + NtLogin))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                customers = JsonConvert.DeserializeObject<List<VCustomer>>(apiResponse);
            }
            return customers;
        }

        public async Task<List<VMachineName>> Main_MachineName_get(int custId)
        {
            List<VMachineName> machine = new List<VMachineName>();
            using (var response = await httpClient.GetAsync("api/common/Main_MachineName_get/" + custId))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                machine = JsonConvert.DeserializeObject<List<VMachineName>>(apiResponse);
            }
            return machine;
        }

        public async Task<ResponseResult> Master_Category_delete(CommonViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/common/Master_Category_delete", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VCategory>> Master_Category_get()
        {
            List<VCategory> categories = new List<VCategory>();
            using (var response = await httpClient.GetAsync("api/common/Master_Category_get"))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                categories = JsonConvert.DeserializeObject<List<VCategory>>(apiResponse);
            }
            return categories;
        }

        public async Task<ResponseResult> Master_Category_insert(CommonViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/common/Master_Category_insert", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> Master_Reason_delete(CommonViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/common/Master_Reason_delete", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VReason>> Master_Reason_Get()
        {
            List<VReason> reasons = new List<VReason>();
            using (var response = await httpClient.GetAsync("api/common/Master_Reason_Get"))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                reasons = JsonConvert.DeserializeObject<List<VReason>>(apiResponse);
            }
            return reasons;
        }

        public async Task<ResponseResult> Master_Reason_insert(CommonViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/common/Master_Reason_insert", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public Task<List<VStatus>> Master_Status_get()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseResult> Master_Supplier_delete(CommonViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/common/Master_Supplier_delete", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VSupplier>> Master_Supplier_get()
        {
            List<VSupplier> suppliers = new List<VSupplier>();
            using (var response = await httpClient.GetAsync("api/common/Master_Supplier_get"))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                suppliers = JsonConvert.DeserializeObject<List<VSupplier>>(apiResponse);
            }
            return suppliers;
        }

        public async Task<ResponseResult> Master_Supplier_insert(CommonViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/common/Master_Supplier_insert", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}
