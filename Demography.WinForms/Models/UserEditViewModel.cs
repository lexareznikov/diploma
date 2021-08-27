using Demography.WinForms.Views.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Models
{
    public class UserEditViewModel
    {
        public UserEditViewModel(EditUser form)
        {
            LastName = form.LastName;
            FirstName = form.FirstName;
            MiddleName = form.MiddleName;
            SexId = form.SexId;
            Email = form.Email;
            Comment = form.Comment;
           // Snils = form.Snils;
            Phone = form.Phone;
            WorkPhone = form.WorkPhone;
            //INN = form.INN;
            //DocTypeId = form.DocTypeId;
            //DocSeries = form.DocSeries;
            //DocNumber = form.DocNumber;
            //DocOrgName = form.DocOrgName;
            //DocDateWith = form.DocDateWith;
            //DocDateOn = form.DocDateOn;
            DocId = form.DocId;
            BidRoleId = form.BidRoleId;
            StatusId = form.StatusId;
           // BirthPlace = form.BirthPlace;
            BirthDate = form.BirthDate;
            Id = form.UserId;
        }
        public UserEditViewModel()
        {

        }
        public int Id { get; set; }
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
        public DateTime? BirthDate { get; set; }
        public int? DocTypeId { get; set; }
        public string DocSeries { get; set; }
        public string DocNumber { get; set; }
        public string DocOrgName { get; set; }
        public int? DocId { get; set; }
        public DateTime? DocDateWith { get; set; }
        public DateTime? DocDateOn { get; set; }
        public int? BidRoleId { get; set; }
        public int? StatusId { get; set; }
        public string BirthPlace { get; set; }


    }
}
