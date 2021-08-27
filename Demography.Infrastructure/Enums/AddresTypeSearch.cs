using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum AddresTypeSearch
    {
        [Display(Name = "Адрес регистрации")]
        Registration = 1,

        [Display(Name = "Адрес места жительства")]
        LivingPlace = 2
    }
}