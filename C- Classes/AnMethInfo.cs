using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSD_schema
{
    public class AnMethInfo
    {
        public double? diskConc { get; set; }
        public double? diskDiam { get; set; }
        public decimal? methSensitivity { get; set; }
        public decimal? methSpecificity { get; set; }
        public double? contactTime_min { get; set; }
        public double? contactTemp_C { get; set; }
        public string com { get; set; }
    }
}
