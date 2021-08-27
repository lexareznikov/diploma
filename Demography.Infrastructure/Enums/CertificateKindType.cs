using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum CertificateKindType
    {
        [Display(Name = "Окончательное")]
        Final = 1,

        [Display(Name = "Предварительное")]
        Preliminary = 2,

        [Display(Name = "Взамен окончательного")]
        InsteadFinal = 3,

        [Display(Name = "Взамен предварительного")]
        InsteadPreliminary = 4
    }
}