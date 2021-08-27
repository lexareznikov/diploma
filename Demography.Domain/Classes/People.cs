using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Demography.Domain.Classes
{
    [Table("people",Schema = "dem")]
    public class People
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("lastname")]
        public string LastName { get; set; }

        [Column("firstname")]
        public string FirstName { get; set; }

        [Column("middlename")]
        public string MiddleName { get; set; }

        [Column("birthday")]
        public DateTime? BirthDate { get; set; }

        [Column("job")]
        public string Job { get; set; }

        [Column("post")]
        public string Post { get; set; }

        [Column("snils")]
        public string Snils { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("sex_id")]
        public int SexId { get; set; }

        [Column("place_birth")]
        public string PlaceBirth { get; set; }

        [Column("place_living_id")]
        public int? PlaceLivingId { get; set; }

      

        [Column("is_homeless")]
        public bool IsHomeless { get; set; }

        [Column("is_foreigner")]
        public bool IsForeigner { get; set; }

       
        
        [Column("oms_series")]
        public string OmsSeries { get; set; }
        
        [Column("oms_number")]
        public string OmsNumber { get; set; }
        
        [Column("oms_enp")]
        public string OmsEnp { get; set; }
        public virtual ICollection<PeopleDoc> Documents { get; set; }

        public string Name
        {
            get { return string.Format("{0} {1} {2}", LastName, FirstName, MiddleName); }
        }

        public string NameShort
        {
            get { return string.Format("{0} {1}.{2}", LastName, FirstName.Substring(0, 1), (string.IsNullOrEmpty(MiddleName) ? "" : MiddleName.Substring(0, 1) + ".")); }
        }

        [ForeignKey("PlaceLivingId")]
        public virtual Address PlaceLiving { get; set; }
        
    }
}
