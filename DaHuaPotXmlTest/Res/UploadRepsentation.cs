using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Res
{
    [XmlRoot("dta")]
    public class UploadRepsentation : BaseRootRepsentation
    {
        [XmlElement("h")]
        public BaseVersion CompanyVersions { get; set; }
        [XmlElement("data")]
        public BarCodeData CompanyDatas { get; set; }
    }
}
