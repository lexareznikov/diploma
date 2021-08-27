using Demography.WinForms.Views.Blanks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Models
{
    public class AddBlankViewModel
    {

        public AddBlankViewModel(AddBlank form)
        {
            Series = form.Series;
            NumberFirst = form.Number;
            Count = form.Count;
            IncomeDate = form.IncomeDate;
        }

        public string Series
        {
            get; set;
        }
        public string NumberFirst
        {
            get; set;
        }


        public int Count
        {
            get; set;
        }
        public DateTime IncomeDate { get; set; }

    }
}
