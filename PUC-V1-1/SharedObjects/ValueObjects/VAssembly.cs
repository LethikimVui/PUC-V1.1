using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VAssembly
    {
        public Int64 rc { get; set; }
        public int AssyId { get; set; }
        public int MachineId { get; set; }
        public string CustName { get; set; }
        public string MachineName { get; set; }
        public string AssemblyNo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
