using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum CertificateBlankStatus
    {
        [Display(Name = "Первичный")]
        Primary = 1,

        [Display(Name = "Дубликат")]
        Duplicate = 2,

        [Display(Name = "Испорчен")]
        Spoiled = 3
    }
}