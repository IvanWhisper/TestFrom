using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Res
{
    public class BaseRootRepsentation
    {
        [XmlAttribute("st")]
        public string st { get; set; }
        [XmlAttribute("op")]
        public string op { get; set; }

        [XmlAttribute("ercode")]
        public string ercode { get; set; }

        [XmlAttribute("res")]
        public string res { get; set; }
    }
}
