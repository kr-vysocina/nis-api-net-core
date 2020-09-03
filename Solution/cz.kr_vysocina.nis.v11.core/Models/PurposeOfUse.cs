namespace cz.kr_vysocina.nis.v11.core.Models
{
    public enum PurposeOfUse
    {
        [System.Runtime.Serialization.EnumMember(Value = @"EMERGENCY")]
        EMERGENCY = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"TREATMENT")]
        TREATMENT = 1,
        
        [System.Runtime.Serialization.EnumMember(Value = @"PATIENT")]
        PATIENT = 2,
        
        [System.Runtime.Serialization.EnumMember(Value = @"NONNCP")]
        NONNCP = 3,
    }
}
