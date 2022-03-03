using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VStatus
    {
        public byte StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusColor { get; set; }
    }
}