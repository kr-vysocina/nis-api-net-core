using System.Collections.Generic;
using System.Xml.Serialization;

namespace cz.kr_vysocina.nis.v11.core.Models.GetPsExists
{
    [XmlRoot(ElementName="getPsExistsResponse")]
    public class GetPsExistsResponseModel
    {
        [XmlElement(ElementName="patientSummary")]
        public List<PatientSummaryModel> PatientSummaryList { get; set; }
    }
}
