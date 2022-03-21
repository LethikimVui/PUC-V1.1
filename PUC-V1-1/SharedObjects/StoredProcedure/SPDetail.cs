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
        public static string Detail_getpagination = "usp_Detail_getpagination @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7";
        public static string Detail_countpagination = "usp_Detail_countpagination @p0,@p1,@p2,@p3,@p4,@p5,@p6 OUT";
        public static string Detail_Usage_refresh = "usp_Detail_Usage_refresh @p0,@p1";
        public static string Detail_Add = "usp_Detail_add @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9";
        public static string Detail_Delete = "usp_Detail_Delete @p0,@p1";
    }
}
