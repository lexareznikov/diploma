using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.Infrastructure.Enums
{
    public enum UserRegStatus
    {
        [Display(Name = "На рассмотрении")]
        OnReview,

        [Display(Name = "Доступ предоставлен")]
        AccessAllowed,

        [Display(Name = "Доступ не предоставлен")]
        AccessDenied,
    }
}
