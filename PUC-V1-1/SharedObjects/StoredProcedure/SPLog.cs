using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedure
{
    public class SPLog
    {

        public static string Log_update = "usp_Log_update @p0,@p1,@p2,@p3";
        public static string Log_get = "usp_Log_get @p0";

    }
}
