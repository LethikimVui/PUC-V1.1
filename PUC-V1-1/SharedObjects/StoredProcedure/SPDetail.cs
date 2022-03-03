using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedure
{
    public class SPDetail
    {

        public static string Detail_get = "usp_Detail_get @p0,@p1";
        public static string Detail_Usage_refresh = "usp_Detail_Usage_refresh @p0,@p1";

    }
}
