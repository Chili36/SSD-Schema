using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SSD_schema
{
    /// <summary>
    /// This class is a tempclass, its only being used for determining the best way to create compoundtypes for G.01 which is 
    /// like a Foodex2 without the base. Also, this class uses the labels for naming instead of the facets(F00 etc) 
    /// </summary>
    public class CompoundForG01
    {
        [XmlArray]
        [XmlArrayItem(ElementName = "building")]
        public List<string> building { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "source")]
        public List<string> source { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "part")]
        public List<string> part { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "state")]
        public List<string> state { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "ingred")]
        public List<string> ingred { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "medium")]
        public List<string> medium { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "fat")]
        public List<string> fat { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "sweet")]
        public List<string> sweet { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "fort")]
        public List<string> fort { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "qual")]
        public List<string> qual { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "alcohol")]
        public List<string> alcohol { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "dough")]
        public List<string> dough { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "cookext")]
        public List<string> cookext { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "packformat")]
        public List<string> packformat { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "packmat")]
        public List<string> packmat { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "partcon")]
        public List<string> partcon { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "prod")]
        public List<string> prod { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "place")]
        public List<string> place { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "targcon")]
        public List<string> targcon { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "use")]
        public List<string> use { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "riskingred")]
        public List<string> riskingred { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "gen")]
        public List<string> gen { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "rawsource")]
        public List<string> rawsource { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "techno")]
        public List<string> techno { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "purpose-of-raising")]
        public List<string> purposeofraising { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "reproductive-level")]
        public List<string> reproductivelevel { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "animal-age-class")]
        public List<string> animalageclass { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "gender")]
        public List<string> gender { get; set; } = new List<string>();
        [XmlArray]
        [XmlArrayItem(ElementName = "food-additive legislative-class")]
        public List<string> foodadditivelegislativeclass { get; set; } = new List<string>();


    }
}
