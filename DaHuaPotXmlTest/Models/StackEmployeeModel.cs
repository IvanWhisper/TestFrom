using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Models
{
    [XmlRoot("req")]

    public class StackEmployeeModel:BaseRootDto
    {
        [XmlElement("h")]
        public BaseVersion PostCompanyVersions { get; set; }
    }
}
