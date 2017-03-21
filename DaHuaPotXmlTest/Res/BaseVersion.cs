using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Res
{
    public class BaseVersion
    {
        [XmlElement("ver")]
        public string ver { get; set; }
        [XmlElement("time")]
        public string time { get; set; }

    }
}
