using Demography.WinForms.Views.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Models
{
    public class RegistrationModel
    {

        public RegistrationModel(Registration form)
        {

            FirstName = form.FirstName;
            LastName = form.LastName;
            //INN = form.INN;
            Email = form.Email;
            Phone = form.Phone;
            WorkPhone = form.WorkPhone;
            Comment = form.Comment;
            //DocTypeId = form.DocTypeId;
            //DocSeries = form.DocSeries;
            //DocNumber = form.DocNumber;
            //DocOrgName = form.DocOrgName;
            //DocDateWith = form.DocDateWith;
            //DocDateOn = form.DocDateOn;
            //Snils = form.Snils;
            BirthDate = form.BirthDate;
            Clinic = form.Clinic;
            BidRole = form.BidRole;
            Sex = form.Sex;
            //BirthPlace = form.BirthPlace;
            Position = form.Position;
            MiddleName = form.MiddleName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string INN { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string WorkPhone { get; set; }
        public string Comment { get; set; }
        public int? DocTypeId { get; set; }
        public string DocSeries { get; set; }
        public string DocNumber { get; set; }
        public string DocOrgName { get; set; }
        public DateTime? DocDateWith { get; set; }
        public DateTime? DocDateOn { get; set; }
        public string BirthPlace { get; set; }
        public string Snils { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Clinic { get; set; }
        public int? BidRole { get; set; }
        public int? Sex { get; set; }
        public string Position { get; set; } // id+|+version 

    }
}
