
using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Res
{
    [XmlRoot("dta")]
    public class LoginRepsentation:BaseRootRepsentation
    {
        [XmlElement("h")]
        public BaseVersion CompanyVersions { get; set; }

        
        [XmlElement("data")]
        public LoginData CompanyDatas { get; set; }
    }
    public class LoginData
    {
   
        [XmlElement("o")]

        public LoginRange CompanyRanges { get; set; }
    }
    public class LoginRange
    {
        [XmlElement("d")]
        public string d { get; set; }

    }
}
