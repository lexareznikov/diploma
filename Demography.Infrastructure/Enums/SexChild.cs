using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum SexChild
    {
        [Display(Name = "Мальчик")]
        Male = 1,

        [Display(Name = "Девочка")]
        Female = 2
    }
}