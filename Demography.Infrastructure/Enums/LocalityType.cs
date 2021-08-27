//using Demography.Infrastructure.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum LocalityType
    {
        //[RemdXml("городская")]
        [Display(Name = "Город")]
        City = 1,
        //[RemdXml("сельская")]
        [Display(Name = "Село")]
        Village = 2
    }
}