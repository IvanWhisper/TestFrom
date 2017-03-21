using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Models
{
    public class BaseRootDto
    {
        [XmlAttribute("op")]
        public string op { get; set; }
    }
}
