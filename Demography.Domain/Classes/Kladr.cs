using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("kladr", Schema = "kl")]
    public class Kladr
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

        [Column("status")]
        public string Status { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("path")]
        public string Path { get; set; }

        [Column("kladrlevel")]
        public int Level { get; set; }
        
        [Column("parent_code")]
        public string ParentCode { get; set; }

        [ForeignKey("ParentId")]
        public virtual Kladr Parent { get; set; }
    }
}