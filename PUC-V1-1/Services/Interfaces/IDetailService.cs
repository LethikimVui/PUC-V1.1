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
        Task<ResponseResult> Detail_Usage_refresh(DetailViewModel model);

    }
}
