using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum ProfileTypeApp
    {
        [Display(Name = "Заполняющий")]
        FillingUp = 1,

        [Display(Name = "Проверяющий")]
        Checking = 2,

        //[Display(Name = "Учет бланков МИАЦ")]
        //AccountingBlanksMIAC = 3,

        //[Display(Name = "Учет бланков МО")]
        //AccountingBlanksMO = 4,

        

        //[Display(Name = "Админ МО")]
        //AdminMO = 6,

        //[Display(Name = "Эксперт")]
        //Expert = 7,

        [Display(Name = "Админ")]
        Admin = 8,

        [Display(Name = "Медстатистика")]
        Medstatistic = 9,

        //[Display(Name = "Специалист ДЗ")]
        //SpecialistDZ = 10
    }
}