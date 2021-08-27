using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("role", Schema = "main")]
    public class Role
    {
        public Role(){
            Permissions = new HashSet<Permission>();
            //Users = new HashSet<User>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("alies")]
        public string Alies { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("flag")]
        public int Flag { get; set; }

        [Column("profile_type_id")]
        public int? ProfileTypeId { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
        //public virtual ICollection<User> Users { get; set; }
    }
}