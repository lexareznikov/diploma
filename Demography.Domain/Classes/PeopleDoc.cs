using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("pdoc", Schema = "dem")]
    public class PeopleDoc
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("people_id")]
        public int PeopleId { get; set; }

        [Column("doctype_id")]
        public int DoctypeId { get; set; }

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

        [Column("org_code")]
        public string OrgCode { get; set; }

        [ForeignKey("PeopleId")]
        public virtual People People { get; set; }

        [ForeignKey("DoctypeId")]
        public virtual PeopleDocType DocType { get; set; }
    }
}