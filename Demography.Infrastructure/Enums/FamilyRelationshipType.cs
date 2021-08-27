using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.Infrastructure.Enums
{
    public enum FamilyRelationshipType
    {
        [Display(Name = "Мать")]
       Mother = 1,
        [Display(Name = "Отец")]
        Father = 2,
        [Display(Name = "Родственник")]
        Relative = 3,
        [Display(Name = "Уполномоченное лицо")]
        Other = 4,
    }
}
