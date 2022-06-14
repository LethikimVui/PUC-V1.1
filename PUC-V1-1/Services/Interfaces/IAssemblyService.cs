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
   public interface IAssemblyService
    {
        Task<List<VAssembly>> Master_Assembly_get(AssemblyViewModel model);
        Task<int> Master_Assembly_count(AssemblyViewModel model);
        Task<ResponseResult> Master_Assembly_delete(AssemblyViewModel model);
        Task<ResponseResult> Master_Assembly_update(AssemblyViewModel model);
    }
}
