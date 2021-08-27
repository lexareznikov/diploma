using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Models
{
    public class UserAccountViewModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int? SexId { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public string Snils { get; set; }
        public string Phone { get; set; }
        public string WorkPhone { get; set; }
        public string INN { get; set; }
        public int ProfileTypeId { get; set; }
        public string Roles { get; set; }
        public string Rights { get; set; }
     }
}
