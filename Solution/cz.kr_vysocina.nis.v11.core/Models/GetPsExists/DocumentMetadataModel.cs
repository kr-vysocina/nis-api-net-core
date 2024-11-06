using System.Collections.Generic;
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
        
        [XmlElement(ElementName="documentSize")]
        public long? DocumentSize { get; set; }
        
        [XmlElement(ElementName="documentHash")]
        public string DocumentHash { get; set; }
        
        [XmlElement(ElementName="reasonOfHospitalisation")]
        public ReasonOfHospitalisationModel ReasonOfHospitalisation { get; set; }
        
        [XmlArray("authors")]
        [XmlArrayItem("author")]
        public List<AuthorModel> Authors { get; set; }
        
        [XmlElement(ElementName="documentFileType")]
        public DocumentFileTypeEnum DocumentFileType { get; set; }
        
        [XmlElement(ElementName="confidentialityCode")]
        public ConfidentialityCodeEnum ConfidentialityCode { get; set; }
    }
}