using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class AssemblyViewModel : PaginationViewModel
    {
    
        public int AssemblyId { get; set; }
        public int CustId { get; set; }
        public int MachineId { get; set; }
        public string AssemblyNo { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
