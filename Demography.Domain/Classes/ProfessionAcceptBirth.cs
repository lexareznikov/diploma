using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("profession_accept_birth")]
    public class ProfessionAcceptBirth
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}