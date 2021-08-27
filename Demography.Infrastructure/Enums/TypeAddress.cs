using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum TypeAddress
    {
        [Display(Name = "Проживания")]
        Living = 1,

        [Display(Name = "Регистрации")]
        Registration = 2        
    }
}
