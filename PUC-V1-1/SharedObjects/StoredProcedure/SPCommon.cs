using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedure
{
    public class SPCommon
    {
        public static string Customer_get = "usp_Customer_get @p0";
        public static string Main_MachineName_get = "usp_Main_MachineName_get @p0";
        public static string Master_Category_get = "usp_Master_Category_get";
        public static string Master_Supplier_get = "usp_Master_Supplier_get";
        public static string Master_Reason_get = "usp_Master_Reason_get";
        public static string Master_Status_get = "usp_Master_Status_get";
    }
}
