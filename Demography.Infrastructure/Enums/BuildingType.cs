using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum BuildingType
    {
        [Display(Name = "Четный номера")]
        Even = 1,

        [Display(Name = "Нечетные номера")]
        Odd = 2
    }
}