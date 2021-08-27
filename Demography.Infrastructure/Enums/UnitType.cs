using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum UnitType
    {
        [Display(Name = "Минут")]
        Minut = 1,

        [Display(Name = "Часов")]
        Hour = 2,
        
        [Display(Name = "Дней")]
        Day = 3,

        [Display(Name = "Месяц")]
        Monght = 4,

        [Display(Name = "Лет")]
        Year = 5,

        //[Display(Name = "Секунд")]
        //Second = 6
    }
}