using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum ActiveType
    {
        [Display(Name = "Да")]
        No = 0,

        [Display(Name = "Нет")]
        Yes = 1
    }
}