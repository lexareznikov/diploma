using Demography.WinForms.Views.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Models
{
    public class PeopleSearchViewModel
    {

        public PeopleSearchViewModel(ListPeople form)
        {
            BirthDate = form.BirthDate;
            Snils = form.Snils;
            //NumberPolicy = form.NumberPolicy;
            FirstName = form.FirstName;
            LastName = form.LastName;
            MiddleName = form.MiddleName;
        }
        public string Snils { get; set; }
        //public string NumberPolicy { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string LastName { get; set; }
    }
}
