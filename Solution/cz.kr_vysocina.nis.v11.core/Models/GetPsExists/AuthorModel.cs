using System.Collections.Generic;
using System.Xml.Serialization;

namespace cz.kr_vysocina.nis.v11.core.Models.GetPsExists
{
    public class AuthorModel
    {
        [XmlElement(ElementName="person")]
        public string AuthorPerson { get; set; }
        
        [XmlArray("specialities")]
        [XmlArrayItem("speciality")]
        public List<string> AuthorSpecialities { get; set; }
    }
}