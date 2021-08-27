using System.ComponentModel.DataAnnotations;


namespace Demography.Infrastructure.Enums
{
    public enum SnilsMissingReasonType
    {
        
        [Display(Name = "Запрошено, но неизвестно")]
        ASKU = 3,
        
        [Display(Name = "Неизвестно")]
        UNK = 2,
       
        [Display(Name = "Неприменимо")]
        NA = 1,

       
    }
}