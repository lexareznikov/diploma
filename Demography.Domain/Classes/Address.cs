
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("address", Schema = "dem")]
    public class Address
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("country")]
        public string Country { get; set; }
        [Column("locality")]
        public string Locality { get; set; }
        [Column("district")]
        public string District { get; set; }
        [Column("region")]
        public string Region { get; set; }
        [Column("street")]
        public string Street { get; set; }
        [Column("house")]
        public string House { get; set; }
        [Column("flat")]
        public string Flat { get; set; }
        [Column("housing")]
        public string Housing { get; set; }
        [Column("room")]
        public string Room { get; set; }
        [Column("build")]
        public string Build { get; set; }
        [Column("location")]
        public int? Location { get; set; }

        [NotMapped]
        public string FullAddress { get { return string.Format("{0} {1} {2} {3}", string.IsNullOrEmpty(Country)?null:Country+",", string.IsNullOrEmpty(Region) ? null : Region + ",", string.IsNullOrEmpty(Street) ? null : Street + ",", string.IsNullOrEmpty(House) ? null : House); } }

    }
}