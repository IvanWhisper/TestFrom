
using System.Collections.Generic;

using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Res
{
    [XmlRoot("dta")]
    public class EmployeeRepsentation: BaseRootRepsentation
    {
        [XmlElement("h")]
        public BaseVersion h { get; set; }
 

        [XmlElement("data")]
        public EmployeeData data { get; set; }
        
    }
 
    public class EmployeeData
    {
        [XmlElement("o")]
        public List<EmployeeUserData> o { get; set; }
    }

    public class EmployeeUserData
    {
        [XmlElement("d")]
        public List<string> d { get; set; }
   
    }
}
