using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes.Nsi
{
    [Table("position_fed00004", Schema = "nsi")]
    public class PositionFed00004
    {
        [Key, Column("id", Order = 1)]
        public int Id { get; set; }

        [Column("work_position")]
        public string Name { get; set; }

        [Column("federal_code")]
        public string FederalCode { get; set; }

        //[Column("version")]
        [Key, Column("version", Order = 2)]
        public string Version { get; set; }

        [Column("mdp365_code")]
        public int? Mdp365Code { get; set; }
    }
}
