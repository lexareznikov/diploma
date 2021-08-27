using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("document", Schema = "dem")]
    public class Document
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("doc_type_id")]
        public int? DocTypeId { get; set; }

        [Column("series")]
        public string Series { get; set; }

        [Column("number")]
        public string Number { get; set; }

        [Column("issue_dt")]
        public DateTime? IssueDateTime { get; set; }

        [Column("expiration_dt")]
        public DateTime? ExpirationDateTime { get; set; }

        [Column("issuer")]
        public string Issuer { get; set; }

        [ForeignKey("DocTypeId")]
        public virtual PeopleDocType DocType { get; set; }
    }
}
