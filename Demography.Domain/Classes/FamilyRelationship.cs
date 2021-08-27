using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.Domain.Classes
{
    [Table("family_relationship", Schema = "nsi")]
    public class FamilyRelationship
    {
        [Key]
        [Column("code")]
        public int Code { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}
