using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("street", Schema = "kl")]
    public class KladrStreet
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("code")]
        public string Code { get; set; }

        [Column("socr")]
        public string Socr { get; set; }

        [Column("index")]
        public string Index { get; set; }

        [Column("uno")]
        public string Uno { get; set; }

        [Column("gninmb")]
        public string Gninmb { get; set; }

        [Column("okatd")]
        public string Okatd { get; set; }

        [Column("kladr_id")]
        public int? KladrId { get; set; }

        [ForeignKey("KladrId")]
        public virtual Kladr Kladr { get; set; }
    }
}