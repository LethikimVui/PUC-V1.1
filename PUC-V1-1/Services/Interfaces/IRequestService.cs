using SharedObjects.Common;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
   public interface IRequestService
    {
        Task<List<VRequest>> Request_Get(RequestViewModel model);
        Task<List<VRequestDetail>> Request_Detail(RequestViewModel model);
        Task<ResponseResult> Request_insert(RequestViewModel model);
        Task<ResponseResult> Request_Reject(RequestViewModel model);
        Task<ResponseResult> Request_Approve(RequestViewModel model);
    }
}
