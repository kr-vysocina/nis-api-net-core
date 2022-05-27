using System.Collections.Generic;
using System.Xml.Serialization;

namespace cz.kr_vysocina.nis.v11.core.Models.GetPsExists
{
    public class PatientSummaryModel
    {
        [XmlElement(ElementName="sourceIdentifier")]
        public string SourceIdentifier { get; set; }

        [XmlElement(ElementName="sourceName")]
        public string SourceName { get; set; }

        [XmlElement(ElementName="sourceIco")]
        public string SourceIco { get; set; }

        [XmlElement(ElementName="sourceId")]
        public SourceIdModel SourceId { get; set; }

        [XmlElement(ElementName="exists")]
        public bool Exists { get; set; }

        [XmlElement(ElementName="cdaL3Id")]
        public string CdaL3Id { get; set; }

        [XmlElement(ElementName="cdaL3Oid")]
        public string CdaL3Oid { get; set; }

        [XmlElement(ElementName="effectiveTime")]
        public string EffectiveTime { get; set; }

        [XmlElement(ElementName="cdaL1support")]
        public bool CdaL1Support { get; set; }

        [XmlElement(ElementName="cdaL1Id")]
        public string CdaL1Id { get; set; }

        [XmlElement(ElementName="cdaL1Oid")]
        public string CdaL1Oid { get; set; }
        
        [XmlArray("documentList")]
        [XmlArrayItem("document")]
        public List<DocumentMetadataModel> DocumentList { get; set; }
    }
}
