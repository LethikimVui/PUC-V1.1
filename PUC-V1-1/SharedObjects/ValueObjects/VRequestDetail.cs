using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VRequestDetail
    {
        public int? DetailId { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public string Location { get; set; }
        public string CategoryName { get; set; }
        public string Supplier { get; set; }
        public string PartNumber { get; set; }
        public int? Limit { get; set; }
        public int? TriggerLimit { get; set; }
        public string Description { get; set; }
    }
}
