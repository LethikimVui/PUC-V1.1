using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class RequestViewModel
    {
        public int ReqId { get; set; }
        public string ReqNumber { get; set; }
        public string FileName { get; set; }
        public int? DetailId { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public string Location { get; set; }
        public string PartNumber { get; set; }
        public int? Limit { get; set; }
        public int? TriggerLimit { get; set; }
        public byte? IsActive { get; set; }
        public int StatusId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedEmail { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedEmail { get; set; }
        public string Description { get; set; }
    }
}
