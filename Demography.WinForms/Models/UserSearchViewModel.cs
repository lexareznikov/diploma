using Demography.WinForms.Views.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Models
{
    public class UserSearchViewModel
    {
        public UserSearchViewModel(UsersList form)
        {
            RoleId = form.RoleId;
            StatusId = form.StatusId;
            FirstName = form.FirstName;
            LastName = form.LastName;
            MiddleName = form.MiddleName;

        }
        public int? RoleId { get; set; }
        public int? StatusId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
