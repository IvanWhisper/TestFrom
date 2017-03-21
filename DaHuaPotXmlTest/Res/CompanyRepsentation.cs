using System.Collections.Generic;
using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Res
{
    [XmlRoot("dta")]
    public class CompanyRepsentation : BaseRootRepsentation
    {
        [XmlElement("h")]
        public BaseVersion CompanyVersions { get; set; }
        [XmlElement("data")]
        public CompanyData CompanyDatas { get; set; }
    }

    public class CompanyData
    {
        [XmlAttribute("range")]
        public string range { get; set; }
        [XmlElement("o")]
        public List<CompanyRange> CompanyRanges { get; set; }

    }
    public class CompanyRange
    {
        [XmlElement("d")]
        public List<string> d { get; set; }
    }
}
