using System.Collections.Generic;
using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Res
{
    [XmlRoot("dta")]
    public class StackEmployeeRepsentation:BaseRootRepsentation
    {
        [XmlElement("h")]
        public BaseVersion CompanyVersions { get; set; }
        [XmlElement("data")]
        public StackEmployeeData CompanyDatas { get; set; }
    }


    public class StackEmployeeData
    {
        [XmlAttribute("range")]
        public string range { get; set; }
        [XmlElement("o")]

        public List<StackEmployeeRange> CompanyRanges { get; set; }

    }
    public class StackEmployeeRange
    {
        [XmlElement("d")]
        public List<string> d { get; set; }
     
    }
}
