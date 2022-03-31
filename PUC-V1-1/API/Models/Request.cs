using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Models
{
    public partial class Request
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
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Description { get; set; }
    }
}
