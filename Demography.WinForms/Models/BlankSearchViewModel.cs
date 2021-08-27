using Demography.WinForms.Views.Blanks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Models
{
  public  class BlankSearchViewModel
    {
        public BlankSearchViewModel(BlanksList form)
        {
            DateOn = form.DateOn;
            DateWith = form.DateWith;

        }

        public DateTime? DateOn { get; set; }
        public DateTime? DateWith { get; set; }
    }
}
