using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VUser
    {
        public string Ntlogin { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }         
        public Byte? CustId { get; set; }
        public Byte? RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
