using System.Collections.Generic;
using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Res
{
    [XmlRoot("dta")]
    public class BarCodeRepsentation : BaseRootRepsentation
    {
        [XmlElement("h")]
        public BaseVersion CompanyVersions { get; set; }
        [XmlElement("data")]
        public BarCodeData CompanyDatas { get; set; }
    }


    public class BarCodeData
    {
        [XmlAttribute("range")]
        public string range { get; set; }
        [XmlElement("o")]

        public List<BarCodeRange> CompanyRanges { get; set; }
    }
    public class BarCodeRange
    {
        [XmlElement("d")]
        public List<string> d { get; set; }

    }
}
