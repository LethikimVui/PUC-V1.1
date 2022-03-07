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
   public interface IMainService
    {
        Task<List<VMain>> Maintenance_Get(DetailViewModel model);
        Task<int> Main_Count(DetailViewModel model);
        Task<ResponseResult> Main_Add(DetailViewModel model);
        Task<ResponseResult> Main_Delete(DetailViewModel model);
    }
}
