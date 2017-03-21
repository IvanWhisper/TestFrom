using System.Xml.Serialization;


namespace DaHuaPotXmlTest.Models
{
    [XmlRoot("req")]
    public class LoginModel : BaseRootDto
    {

        [XmlElement("h")]
        public BaseVersion PostCompanyVersions { get; set; }
   
    }


}
