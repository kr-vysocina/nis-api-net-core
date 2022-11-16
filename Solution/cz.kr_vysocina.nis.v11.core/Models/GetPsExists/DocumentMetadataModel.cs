using System.Xml.Serialization;

namespace cz.kr_vysocina.nis.v11.core.Models.GetPsExists
{
    public class DocumentMetadataModel
    {
        [XmlElement(ElementName="type")]
        public string Type { get; set; }

        [XmlElement(ElementName="label")]
        public string Label { get; set; }
        
        [XmlElement(ElementName="id")]
        public string Id { get; set; }

        [XmlElement(ElementName="oid")]
        public string Oid { get; set; }
        
        [XmlElement(ElementName="effectiveTime")]
        public string EffectiveTime { get; set; }
    }
}