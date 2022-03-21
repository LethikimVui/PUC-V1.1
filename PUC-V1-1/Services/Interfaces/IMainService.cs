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
        Task<List<VMain>> Maintenance_Get(MainViewModel model);
        Task<int> Main_Count(MainViewModel model);
        Task<ResponseResult> Main_Add(MainViewModel model);
        Task<ResponseResult> Main_Delete(MainViewModel model);
    }
}
