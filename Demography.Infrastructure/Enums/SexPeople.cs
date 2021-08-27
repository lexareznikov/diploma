using System.ComponentModel.DataAnnotations;


namespace Demography.Infrastructure.Enums
{
    //не изменять(федеральный справочник)
    public enum SexPeople
    {
        [Display(Name = "Мужчина")]
        
        Male = 1,

        [Display(Name = "Женщина")]
       
        Female = 2

       
    }
}