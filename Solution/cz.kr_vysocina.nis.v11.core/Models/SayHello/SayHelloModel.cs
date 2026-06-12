using System.Collections.Generic;
using System.Xml.Serialization;

namespace cz.kr_vysocina.nis.v11.core.Models.SayHello
{
    [XmlRoot(ElementName="sayHello")]
    public class SayHelloModel
    {
        [XmlElement(ElementName="description")]
        public string Description { get; set; }
        
        [XmlElement(ElementName="wave")]
        public string Wave { get; set; }
        
        [XmlElement(ElementName="ridOnly")]
        public bool? RidOnly { get; set; }

        [XmlElement(ElementName="servertime")]
        public string ServerTime { get; set; }

        [XmlElement(ElementName="isName")]
        public string IsName { get; set; }

        [XmlElement(ElementName="isVersion")]
        public string IsVersion { get; set; }

        [XmlElement(ElementName="environment")]
        public string Environment { get; set; }

        [XmlElement(ElementName="cdaIgVersion")]
        public string CdaIgVersion { get; set; }

        [XmlElement(ElementName="fhirIgVersion")]
        public string FhirIgVersion { get; set; }

        [XmlElement(ElementName="mvcVersion")]
        public string MvcVersion { get; set; }

        [XmlArray(ElementName="LiveSourceList")]
        [XmlArrayItem(ElementName="LiveSource")]
        public List<LiveSourceModel> LiveSourceList { get; set; }
    }
}
