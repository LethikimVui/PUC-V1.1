using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VLog
    {
        public long No { get; set; }
        public string CustName { get; set; }
        public string MachineName { get; set; }
        public string Location { get; set; }
        public string PartNumber { get; set; }
        public Int32? Limit { get; set; }
        public string CategoryName { get; set; }
        public string Supplier { get; set; }
        public int? UsedTimes { get; set; }
        public string Message { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedName { get; set; }
    }
}
