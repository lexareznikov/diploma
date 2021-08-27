using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum CertificateStatus
    {
        [Display(Name = "Создано")]
        Created = 0,

        [Display(Name = "На экспертизе")]
        Expertise = 1,

        [Display(Name = "Возврат")]
        Return = 2,

        [Display(Name = "К печати")]
        Print = 3,

        [Display(Name = "Выдано")]
        Issued = 4

       
    }
}