using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Demography.Domain.Classes.Nsi;

namespace Demography.Domain.Classes
{
    [Table("user_clinic", Schema = "main")]
    public class UserClinic
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("user_id")]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Column("clinic_id")]
        [ForeignKey("Clinic")]
        public int ClinicId { get; set; }
        [Column("post_code")]
        public int? PostCode { get; set; }

        [Column("post_version")]
        public string PostVersion { get; set; }

        public virtual PositionFed00004 Position { get; set; }
        public virtual Clinic Clinic { get; set; }
        public virtual User User { get; set; }
    }
}