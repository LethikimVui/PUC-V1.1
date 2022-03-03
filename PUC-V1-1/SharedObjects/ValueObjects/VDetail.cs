using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VDetail
    {

        public int DetailId { get; set; }
        public Byte? CustId { get; set; }
        public string CustName { get; set; }
        public int? MachineId { get; set; }
        public string MachineName { get; set; }
        public string PartNumber { get; set; }
        public string Location { get; set; }
        public string Supplier { get; set; }
        public int? SupplierId { get; set; }
        public string CategoryName { get; set; }
        public int? CategoryId { get; set; }
        public int? UsedTimes { get; set; }
        public int? TriggerLimit { get; set; }
        public int? Limit { get; set; }
        public int? Level { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string DisplayName { get; set; }
        public Int64 rc { get; set; }
    }
}
