using System.Collections.Generic;
using System.Xml.Serialization;

namespace cz.kr_vysocina.nis.v11.core.Models.SayHello
{
    [XmlRoot(ElementName="sayHello")]
    public class SayHelloModel
    {
        [XmlElement(ElementName="description")]
        public string Description { get; set; }

        [XmlElement(ElementName="servertime")]
        public string ServerTime { get; set; }

        [XmlArray(ElementName="LiveSourceList")]
        [XmlArrayItem(ElementName="LiveSource")]
        public List<LiveSourceModel> LiveSourceList { get; set; }
    }
}
