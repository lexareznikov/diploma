using Demography.WinForms.Views.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Models
{
    public class NewsViewModel
    {
        public NewsViewModel(AddNews form)
        {
                NewsFull = form.NewsFullText;
                Date = form.NewsDate;
                NameShort = form.NameShortText;
        }
        public NewsViewModel()
        {
            
        }

        public string NewsFull { get; set; }
        public DateTime Date { get; set; }
        public string NameShort { get; set; }
    }
}
