
using System.Collections.Generic;

using System.Xml.Serialization;

namespace DaHuaPotXmlTest.Res
{
    [XmlRoot("dta")]
    public class OverdueCompanyRepsentation: BaseRootRepsentation
    {
        [XmlElement("h")]
        public BaseVersion h { get; set; }
        [XmlElement("varlist")]
        public OverdueCompanyMsg varlist { get; set; }

        [XmlElement("data")]
        public OverdueCompanyData data { get; set; }

    }
    public class OverdueCompanyMsg 
    {
        [XmlElement("var")]
        public List<OverdueCompanyVar> var { get; set; }
    }
    public class OverdueCompanyVar
    {
        [XmlAttribute("name")]
        public string name { get; set; }
    }
    public class OverdueCompanyData
    {
        [XmlElement("o")]
        public List<OverdueCompanyUserData> o { get; set; }
    }

    public class OverdueCompanyUserData
    {
        //[XmlElement("com")]
        //public string com { get; set; }

        [XmlElement("d")]
        public List<string> d { get; set; }
    }
}



