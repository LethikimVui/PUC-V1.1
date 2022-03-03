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
   public interface ILogService
    {
        Task<List<VLog>> Log_get(LogViewModel model);
        Task<ResponseResult> Log_update(LogViewModel model);

    }
}
