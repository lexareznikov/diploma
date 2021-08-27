using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum DateRangeKind
    {
        [Display(Name = "Не указан")]
        NotDefined = 0,

        [Display(Name = "Вчера")]
        Yesterday = 1,

        [Display(Name = "Сегодня")]
        Today = 2,

        [Display(Name = "Завтра")]
        Tomorrow = 3,

        [Display(Name = "за последнюю неделю")]
        LastWeek = 4,

        [Display(Name = "за последние 2 недели")]
        Last2Weeks = 5,

        [Display(Name = "за последний месяц")]
        LastMonth = 6,

        [Display(Name = "за последние 3 месяца")]
        Last3Month = 7,

        [Display(Name = "за последние 6 месяцев")]
        Last6Month = 8,

        [Display(Name = "за последний год")]
        LastYear = 9
    }
}