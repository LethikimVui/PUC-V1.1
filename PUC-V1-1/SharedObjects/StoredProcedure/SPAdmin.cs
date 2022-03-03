using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedure
{
    public class SPAdmin
    {
        public static string Access_Role_get = "usp_Access_Role_get";
        public static string Access_UserRole_get = "usp_Access_UserRole_Get";
        public static string Access_UserRole_Get_By_Id = "usp_Access_UserRole_Get_By_Id @p0";
        public static string Access_UserRole_insert = "usp_Access_UserRole_insert @p0,@p1,@p2,@p3,@p4";
        public static string Access_UserRole_update = "usp_Access_UserRole_update @p0,@p1,@p2,@p3,@p4";
        public static string Access_UserRole_delete = "usp_Access_UserRole_delete @p0,@p1";

     
    }
}
