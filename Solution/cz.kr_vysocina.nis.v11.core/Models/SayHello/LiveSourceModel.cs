using System.Xml.Serialization;

namespace cz.kr_vysocina.nis.v11.core.Models.SayHello
{
    public class LiveSourceModel
    {
        [XmlElement(ElementName="sourceName")]
        public string SourceName { get; set; }
        
        [XmlElement(ElementName="sourceIco")]
        public string SourceIco { get; set; }
        
        [XmlElement(ElementName="status")]
        public string Status { get; set; }
    }
}
