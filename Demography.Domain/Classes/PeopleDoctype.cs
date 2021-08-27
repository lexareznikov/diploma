using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("doctype", Schema = "nsi")]
    public class PeopleDocType
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("synonim")]
        public string Synonim { get; set; }

        [Column("order")]
        public int Order { get; set; }
       
    }
}