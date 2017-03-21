using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Models
{
    [XmlRoot("req")]
    public class BarCodeItcAllModel: BaseRootDto
    {
        [XmlElement("h")]
        public BaseVersion PostCompanyVersions { get; set; }
    }
}
