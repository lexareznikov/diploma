using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("user_role", Schema = "main")]
    public class UserRole
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("user_id")]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Column("role_id")]
        [ForeignKey("Role")]
        public int RoleId { get; set; }

        [Column("order_date")]
        public DateTime? OrderDate { get; set; }

        [Column("order_number")]
        public string OrderNumber { get; set; }

        public virtual User User { get; set; }
        public virtual Role Role { get; set; }

    }
}