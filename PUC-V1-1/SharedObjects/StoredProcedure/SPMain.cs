using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedure
{
    public class SPMain
    {
        public static string Main_get = "usp_Main_get @p0,@p1,@p2,@p3,@p4,@p5,@p6";
        public static string Main_Count = "usp_Main_count @p0,@p1,@p2,@p3,@p4";
        public static string Main_Add = "usp_Main_Add @p0,@p1,@p2,@p3,@p4,@p5";
        public static string Main_Delete = "usp_Main_Delete @p0,@p1";
        //public static string Main_get_machine = "usp_Main_get_machine @p0";

    }
}
