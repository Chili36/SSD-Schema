using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSD_schema
{
    public class Foodex2
    {
        public string BaseTerm { get; set; }
        public List<Facet> Facets { get; set; } = new List<Facet>();
    }
}
