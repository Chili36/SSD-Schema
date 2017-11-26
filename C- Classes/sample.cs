using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SSD_schema
{
    public class Sample
    {
        public Foodex2 sampMatCode { get; set; }
        public Foodex2 anMatCode { get; set; }
        public Evalinfo evalinfo { get; set; }
        public string localOrgId { get; set; }
        public string localOrgCountry { get; set; }
        public string localOrgInfo { get; set; }
        public string progId { get; set; }
        public string progLegalRef { get; set; }
        public string progType { get; set; }
        public string sampler { get; set; }
        public string sampPoint { get; set; }
        public string sampUnitType { get; set; }
        public string sampId { get; set; }
        public string sampCountry { get; set; }
        public int sampY { get; set; }
        public string sampMatType { get; set; }
        public string origCountry { get; set; }
        public int analysisY { get; set; }
        public string labAccred { get; set; }
        public string paramType { get; set; }
        public string anMethRefCode { get; set; }
        public string anMethType { get; set; }
        public string resId { get; set; }
        public string accredProc { get; set; }
        public string resUnit { get; set; }
        public string resType { get; set; }
        public string evalCode { get; set; }
        public string paramCode { get; set; }
        public AnMethInfo anMethInfo { get; set; }
        public string sampStrategy { get; set; }
        public SampUnitIds sampUnitIds { get; set; }
        public sampEventInfo sampEventInfo { get; set; }
        public Sampinfo sampInfo { get; set; }
        public SampMatInfo sampMatinfo { get; set; }
        public SampAnInfo sampAnInfo { get; set; }
        public CompoundForG01 anMatCodeAsCompund { get; set; }
        public string anMatInfo { get; set; }
        public string anPortinfo { get; set; }
        public string isolParamCode { get; set; }
        public string labInfo { get; set; }
        public AnMethInfo anMethinfo { get; set; }
        public ExprResPerc exprResPerc { get; set; }
        public string sampMethod
        {
            get; set;
        }
        public string sampEventId
        {
            get; set;
        }

        [XmlArray]
        [XmlArrayItem(ElementName = "actTaken")]
        public string[] actTakenCode { get; set; }
    }
}
