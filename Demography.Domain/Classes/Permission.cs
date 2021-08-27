using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("permission", Schema = "main")]
    public class Permission
    {
        public Permission(){
            Roles = new HashSet<Role>();
            Users = new HashSet<User>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("alias")]
        public string Alias { get; set; }

        [Column("is_individual")]
        public bool IsIndividual { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}