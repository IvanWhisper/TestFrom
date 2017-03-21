using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Res
{
    [XmlRoot("dta")]
    public class SignOutRepsentation
    {
        [XmlElement("h")]
        public BaseVersion CompanyVersions { get; set; }
        [XmlElement("data")]
        public SignOutData CompanyDatas { get; set; }
    }
    public class SignOutData
    {

        [XmlElement("o")]

        public SingoutRange CompanyRanges { get; set; }
    }
    public class SingoutRange
    {
        [XmlElement("d")]
        public string d { get; set; }

    }
}
