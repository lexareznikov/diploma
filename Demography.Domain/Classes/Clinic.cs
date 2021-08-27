using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("clinic", Schema = "dem")]
    public class Clinic
    {
        public Clinic()
        {
            Childrens = new List<Clinic>();
            UserClinic = new HashSet<UserClinic>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("short_name")]
        public string ShortName { get; set; }

        [Column("okpo")]
        public string Okpo { get; set; }

        [Column("ogrn")]
        public string OGRN { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("inn")]
        public string INN { get; set; }
      
       

        [Column("fax")]
        public string FAX { get; set; }

     

        [Column("email")]
        public string Email { get; set; }
        [Column("country")]
        public string Country { get; set; }
        [Column("region")]
        public string Region { get; set; }
        [Column("district")]
        public string District { get; set; }
        [Column("locality")]
        public string Locality { get; set; }
        [Column("street")]
        public string Street { get; set; }
        [Column("house")]
        public string House { get; set; }
        [Column("build")]
        public string Build { get; set; }
        [Column("actual_address")]
        public string ActualAddress { get; set; }

        [Column("director_id")]
        public int? DirectorId { get; set; }


        [ForeignKey("ParentId")]
        public virtual ICollection<Clinic> Childrens { get; set; }

        public virtual ICollection<UserClinic> UserClinic { get; set; }
    }
}
