using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.Infrastructure.Enums
{
    public enum FamilyStatusType
    {
        [Display(Name = "состояла в зарегистрированном браке")]
        InMarriage = 1,
        [Display(Name = "не состояла в зарегистрированном браке")]
        NotMarried = 2,
        [Display(Name = "неизвестно")]
        Unknown = 3,
    }
}
