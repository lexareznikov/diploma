using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    public abstract class Remark
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("certificate_id")]
        public int CertificateId { get; set; }

        [Column("field_name")]
        public string FieldName { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("note")]
        public string Note { get; set; }

        [Column("is_fixed")]
        public bool IsFixed { get; set; }

        [Column("created_date")]
        public DateTime CreatedDate { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; } 
    }
}