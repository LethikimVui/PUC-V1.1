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
   public interface IDetailService
    {
        Task<List<VDetail>> Get(DetailViewModel model);
        Task<List<VDetail>> Detail_getpagination(DetailViewModel model);
        Task<int> Detail_countpagination(DetailViewModel model);
        Task<ResponseResult> Detail_Usage_refresh(DetailViewModel model);
        Task<ResponseResult> Detail_Add(DetailViewModel model);
        Task<ResponseResult> Detail_Delete(DetailViewModel model);
    }
}
