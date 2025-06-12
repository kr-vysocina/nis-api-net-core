using System.Xml.Serialization;

namespace cz.kr_vysocina.nis.v11.core.Models.GetPsExists
{
    public class ReasonOfHospitalisationModel
    {
        [XmlElement(ElementName="code")]
        public string Code { get; set; }
        
        [XmlElement(ElementName="codingScheme")]
        public string CodingScheme { get; set; }
        
        [XmlElement(ElementName="text")]
        public string Text { get; set; }
    }
}