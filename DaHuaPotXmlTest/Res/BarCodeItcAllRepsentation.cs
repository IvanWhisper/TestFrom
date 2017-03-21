using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Res
{
    [XmlRoot("dta")]
    public class BarCodeItcAllRepsentation: BaseRootRepsentation
    {
        [XmlElement("h")]
        public BaseVersion CompanyVersions { get; set; }
        [XmlElement("data")]
        public BarCodeItcAllData barCodeItcAllData { get; set; }
    }
    public class BarCodeItcAllData
    {
        [XmlElement("o")]
        public List<BarCodeItcAllRange> barCodeItcAllRangeRanges { get; set; }

    }
    public class BarCodeItcAllRange
    {
        [XmlElement("d")]
        public List<string> d { get; set; }
    }
}
