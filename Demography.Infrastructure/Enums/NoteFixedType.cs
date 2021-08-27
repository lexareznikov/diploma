using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum NoteFixedType
    {
        [Display(Name = "Да")]
        Yes = 1,

        [Display(Name = "Нет")]
        No = 2
    }
}
