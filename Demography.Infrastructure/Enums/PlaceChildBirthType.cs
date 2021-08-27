using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.Infrastructure.Enums
{
    public enum  PlaceChildBirthType
    {
        [Display(Name = "в стационаре")]
        Clinic = 1,
        [Display(Name = "дома")]
        Home = 2,
        [Display(Name = "в другом месте")]
        OtherPlace = 3,
        [Display(Name = "неизвестно")]
        Unknown = 4,
    }
}
