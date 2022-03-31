using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedure
{
    public class SPRequest
    {
        public static string Request_Get = "usp_Request_Get @p0";
        public static string Request_Detail = "usp_Request_Detail @p0";
        public static string Request_insert = "usp_Request_insert @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9";



        public static string Request_Reject = "usp_Request_Reject @p0,@p1,@p2";
        public static string Request_Approve = "usp_Request_Approve @p0,@p1,@p2";

    }
}
