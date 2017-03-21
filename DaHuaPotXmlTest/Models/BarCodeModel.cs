

using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Models
{
    
    [XmlRoot("req")]
    public class BarCodeModel: BaseRootDto
    {
   
        [XmlElement("h")]
        public BaseVersion PostCompanyVersions { get; set; }
    }

  
}
