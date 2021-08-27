using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.Domain.Classes
{
    [Table("blank_income")]
    public class BlankIncome
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("create_dt")]
        public DateTime CreateDate { get; set; }

        [Column("series")]
        public string Series { get; set; }

        [Column("number_first")]
        public string NumberFirst { get; set; }


        [Column("count")]
        public int Count { get; set; }
        [Column("user_id")]
        public int? UserId { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
