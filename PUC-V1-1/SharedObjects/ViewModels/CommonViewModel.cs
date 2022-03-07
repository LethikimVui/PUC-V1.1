using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class CommonViewModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ReasonId { get; set; }
        public string Reason { get; set; }
        public int SupplierId { get; set; }
        public string Supplier { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
