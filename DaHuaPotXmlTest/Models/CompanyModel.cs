
using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Models
{

    [XmlRoot("req")]
    public class CompanyModel:BaseRootDto
    {

        [XmlAttribute("range")]
        public string range { get; set; }

        [XmlElement("h")]
        public BaseVersion PostCompanyVersions { get; set; }
    }

}
