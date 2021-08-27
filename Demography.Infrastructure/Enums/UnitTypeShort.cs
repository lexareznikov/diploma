using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum UnitTypeShort
    {
        [Display(Name = "Дней")]
        Day = 3,

        [Display(Name = "Месяц")]
        Monght = 4,

        [Display(Name = "Лет")]
        Year = 5
    }
}