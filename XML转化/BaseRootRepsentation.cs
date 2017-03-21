using System.Xml.Serialization;

namespace XML转化
{ 
    public class BaseRootRepsentation
    {
        [XmlAttribute("xmlns")]
        public string xmlns { get; set; }
    }
}
