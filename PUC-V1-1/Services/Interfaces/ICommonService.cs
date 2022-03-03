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
   public interface ICommonService
    {
        Task<List<VCustomer>> Customer_get(string NtLogin);
        Task<List<VCategory>> Master_Category_get();
        Task<List<VSupplier>> Master_Supplier_get();
        Task<List<VMachineName>> Main_MachineName_get(int custId);
        Task<List<VReason>> Master_Reason_Get();
        Task<List<VStatus>> Master_Status_get();
    }
}
