using Demography.WinForms.Views.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Models
{
    public class UserClinicViewModel
    {
        public UserClinicViewModel(AddPosition form)
        {
            ClinicId = form.ClinicId;
            Position = form.Position;
        }
        public int ClinicId { get; set; }
        public string Position { get; set; }
    }
}
