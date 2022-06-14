using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VApproval
    {
      
        public string Ntlogin { get; set; }
        public Byte plantID { get; set; }
        public Byte custID { get; set; }
        public int reqId { get; set; }
        public string Email { get; set; }
    }
}
