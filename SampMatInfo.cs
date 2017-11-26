using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSD_schema
{
    public class SampMatInfo
    {
        public string brandName { get; set; }
        public string manuf { get; set; }
        public string com { get; set; }
        public int? prodY { get; set; }
        public int? prodM { get; set; }
        public int? prodD { get; set; }
        public int? expiryY { get; set; }
        public int? expiryM { get; set; }
        public int? expiryD { get; set; }
    }
}
