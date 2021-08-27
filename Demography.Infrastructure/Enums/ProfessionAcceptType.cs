using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.Infrastructure.Enums
{
   public enum ProfessionAcceptType
    {
        [Display(Name = "врач-акушер-гинеколог")]
        OBGYN = 1,
        [Display(Name = "фельдшер, акушерка")]
        Midwife = 2,
        [Display(Name = "другое лицо")]
        OtherPerson = 3
    }
}
