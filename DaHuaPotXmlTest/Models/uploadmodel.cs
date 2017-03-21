
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Models
{
    [XmlRoot("req")]
    public class Uploadmodel : BaseRootDto
    {

        [XmlElement("h")]
        public BaseVersion PostCompanyVersions { get; set; }
        [XmlElement("data")]
        public UploadData CompanyDatas { get; set; }
    }
    public class UploadData
    {
        [XmlElement("o")]

        public UploadRange CompanyRanges { get; set; }
    }
    public class UploadRange
    {
        [XmlElement("d")]
        public List<string> d { get; set; }

    }
}
