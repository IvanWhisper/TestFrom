using System.Collections.Generic;
using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Res
{
    [XmlRoot("dta")]
    public class CompanyZipRepsentation : BaseRootRepsentation
    {
        [XmlElement("h")]
        public BaseVersion CompanyVersions { get; set; }
        [XmlElement("data")]
        public CompanyData CompanyDatas { get; set; }
    }

    public class CompanyZipData
    {
        [XmlElement("o")]
        public List<CompanyRange> CompanyRanges { get; set; }

    }
    public class CompanyZipRange
    {
        [XmlElement("d")]
        public List<string> d { get; set; }
    }
}
