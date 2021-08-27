using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum KladrLevel
    {
        [Display(Name = "Регион:")]
        Region = 1,

        [Display(Name = "Район:")]
        District = 2,

        [Display(Name = "Город:")]
        City = 3,

        [Display(Name = "Населенный пункт:")]
        Locality = 4,

        [Display(Name = "Улица:")]
        Street = 5
    }
}