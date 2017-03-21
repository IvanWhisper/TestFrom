using System.Xml.Serialization;
namespace DaHuaPotXmlTest.Models
{
    public class BaseVersion
    {
        [XmlElement("ver")]
        public string ver { get; set; }
        [XmlElement("company")]
        public string company { get; set; }
        [XmlElement("user")]
        public string user { get; set; }
        [XmlElement("pass")]
        public string pass { get; set; }
        [XmlElement("dev1")]
        public string dev1 { get; set; }
        [XmlElement("dev2")]
        public string dev2 { get; set; }

       
    }
}
