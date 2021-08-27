using System;
using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    [Flags]
    public enum RoleApp
    {
        //[Display(Name = "")]
        //None = 0,
        
        [DatabaseValueAttribute(1)]
        [Display(Name ="Врач МСР")]
        DoctorCertBirth = 1,
       
        [DatabaseValueAttribute(2)]
        [Display(Name = "Проверяющий свид. о рождении")]
        CheckingCertificateBirth = 2,
        //[DatabaseValueAttribute(3)]
        //[Display(Name = "Админ МО")]
        //AdminMO = 4,
        //[DatabaseValueAttribute(4)]
        //[Display(Name = "Эксперт")]
        //Expert = 8,
        [DatabaseValueAttribute(5)]
        [Display(Name = "Админ")]
        Admin = 16,
        [DatabaseValueAttribute(6)]
        [Display(Name = "Медстатистика")]
        Medstatistic = 32
    }
}