using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VRequest
    {
        public Int64 rc { get; set; }
        public int ReqId { get; set; }
        public string ReqNumber { get; set; }
        public string CustName { get; set; }
        public string MachineName { get; set; }
        public string FileName { get; set; }
        public string Status { get; set; }
        public string StatusColor { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedName { get; set; }
        public string CreatedEmail { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Description { get; set; }
    }
}
