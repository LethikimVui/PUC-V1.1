using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class LogViewModel
    {
        public int MachineId { get; set; }
        public int DetailId { get; set; }
        public int UsedTimes { get; set; }
        public string Message { get; set; }
        public string UpdatedBy { get; set; }
    }
}
