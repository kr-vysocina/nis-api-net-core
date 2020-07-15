using System.Collections.Generic;
using System.Xml.Serialization;

namespace cz.kr_vysocina.nis.v11.core.Models.GetPsExists
{
    public class SourceIdModel
    {
        [XmlElement(ElementName="sourceIdType")]
        public List<string> SourceIdTypeList { get; set; }

        [XmlElement(ElementName="sourceIdValue")]
        public List<string> SourceIdValueList { get; set; }
    }
}
