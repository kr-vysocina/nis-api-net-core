namespace cz.kr_vysocina.nis.v11.core.Models.GetPsExists
{
    public enum DocumentFileTypeEnum
    {
        [System.Runtime.Serialization.EnumMember(Value = @"PDF,")]
        PDF = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"PNG")]
        PNG = 1,
        
        [System.Runtime.Serialization.EnumMember(Value = @"JPEG")]
        JPEG = 2,
    }
}