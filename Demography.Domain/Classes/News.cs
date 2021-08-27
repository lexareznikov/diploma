using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("news")]
    public class News
    {
        public News(){
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("news_short")]
        public string NewsShort { get; set; }

        [Column("news_full")]
        public string NewsFull { get; set; }

       
    }
}