using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class DetailViewModel : PaginationViewModel
    {
        public int DetailId { get; set; }
        public string strDetailId { get; set; }
        public int CustId { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public string strCustId { get; set; }
        public int MachineId { get; set; }
        public string strMachineId { get; set; }
        public string MachineName { get; set; }
        public string Description { get; set; }
        //public string SerialNumber { get; set; }
        public int? Limit { get; set; }
        public byte CustomLimit { get; set; }
        public int? TriggerLimit { get; set; }
        public string PartNumber { get; set; }
        public string Location { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
