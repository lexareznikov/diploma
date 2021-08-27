using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("medical_service", Schema = "nsi")]
    public class MedicalService
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("code")]
        public string Code { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("actual")]
        public string Actual { get; set; }

        [Column("abolition_dt")]
        public DateTime? AbolitionDt { get; set; }
    }
}