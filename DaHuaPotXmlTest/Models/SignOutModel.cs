using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Models
{
    [XmlRoot("req")]
    public class SignOutModel:BaseRootDto
    {

        [XmlElement("h")]
        public BaseVersion PostCompanyVersions { get; set; }
    }
}
