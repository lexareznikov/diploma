using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("blank")]
    public class Blank
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("series")]
        public string Series { get; set; }

        [Column("number")]
        public string Number { get; set; }


        [Column("is_used")]
        public bool IsUsed{ get; set; }

        [Column("income_id")]
        public int IncomeId { get; set; }

        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        [ForeignKey("IncomeId")]
        public virtual BlankIncome Incomes { get; set; }
    }
}