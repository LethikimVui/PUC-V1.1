using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VMain
    {
        public int MachineId { get; set; }
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string MachineName { get; set; }
        public string SerialNumber { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public long rc { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
