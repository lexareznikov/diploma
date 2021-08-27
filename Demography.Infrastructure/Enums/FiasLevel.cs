using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.Infrastructure.Enums
{
    public enum FiasLevel
    {
        [Display(Name = "Регион:")]
        Region = 1,

        [Display(Name = "Район:")]
        District = 3,

        [Display(Name = "Город:")]
        City = 4,

        [Display(Name = "Населенный пункт:")]
        Locality = 6,

        [Display(Name = "Улица:")]
        Street = 7
    }
}
