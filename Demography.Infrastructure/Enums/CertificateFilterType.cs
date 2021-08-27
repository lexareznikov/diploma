using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum CertificateFilterType
    {
        [Display(Name = "ФИО")]
        Fio = 1,

        [Display(Name = "ФИО + Дата рождения")]
        FioBirthDt = 2,

        [Display(Name = "ФИО + Дата смерти")]
        FioDeathDt = 3,
    }
}
