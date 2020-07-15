using cz.kr_vysocina.nis.v11.core.Models;
using cz.kr_vysocina.nis.v11.core.Models.GetPsExists;
using cz.kr_vysocina.nis.v11.core.Models.SayHello;

namespace cz.kr_vysocina.nis.v11.core.Providers
{
    public interface IDataProvider
    {
        SayHelloModel GetSayHelloData();

        GetPsExistsResponseModel GetPsExistsData(IdType idType, string idValue, PurposeOfUse purposeOfUse, string subjectNameId,
            string requestOrganizationId, string requestId);

        byte[] GetPsCdaData(string sourceIdentifier, IdType idType, string idValue, PurposeOfUse purposeOfUse, string subjectNameId,
            string requestOrganizationId, CDAType cdaType, string cdaId, string cdaOid, string requestId);
    }
}
