using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedure
{
    public class SPAssembly
    {
        public static string Master_Assembly_get = "usp_Master_Assembly_get @p0,@p1,@p2,@p3,@p4";
        public static string Master_Assembly_count = "usp_Master_Assembly_count @p0,@p1,@p2,@p3 out";

        public static string Master_Assembly_delete = "usp_Master_Assembly_delete @p0,@p1";
        public static string Master_Assembly_update = "usp_Master_Assembly_update @p0,@p1,@p2";
       

    }
}
