using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Models
{
    [XmlRoot("req")]

    public class EmployeeModel: BaseRootDto
    {
        [XmlElement("h")]
        public BaseVersion PostCompanyVersions { get; set; }
    }


}
