using Demography.WinForms.Views.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Models
{
    public class PeopleEditViewModel
    {
        public PeopleEditViewModel(CreateEditPeople form)
        {
            OmsEnp = form.OmsEnp;
            OmsNumber = form.OmsNumber;
            OmsSeries = form.OmsSeries;
            WorkPlace = form.WorkPlace;
            Position = form.Position;
            Snils = form.Snils;
            FirstName = form.FirstName;
            LastName = form.LastName;
            MiddleName = form.MiddleName;
            BirthPlace = form.BirthPlace;
            Phone = form.Phone;
            BirthDate = form.BirthDate;
           // SexId = form.SexId;
            DocTypeId = form.DocTypeId;
            DocSeries = form.DocSeries;
            DocNumber = form.DocNumber;
            DocDateOn = form.DocDateOn;
            DocDateWith = form.DocDateWith;
            DocOrgName = form.DocOrgName;
            Country = form.Country;
            Locality = form.Locality;
            District = form.District;
            Region = form.Region;
            Street = form.Street;
            House = form.House;
            Flat = form.Flat;
            Housing = form.Housing;
            Room = form.Room;
            Build = form.Build;
            Location = form.Location;
            IsForeigner = form.IsForeigner;
            IsHomeless = form.IsHomeless;
            PeopleId = form.PeopleId;
            WithoutDoc = form.WithoutDoc;
        }
        public PeopleEditViewModel()
        {
        }

        public string OmsEnp { get; set; }
        public string OmsNumber { get; set; }
        public string OmsSeries { get; set; }
        public string WorkPlace { get; set; }
        public string Position { get; set; }
        public string Snils { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string BirthPlace { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? SexId { get; set; }
        public int? DocTypeId { get; set; }
        public string DocSeries { get; set; }
        public string DocNumber { get; set; }
        public DateTime? DocDateOn { get; set; }
        public DateTime? DocDateWith { get; set; }
        public string DocOrgName { get; set; }
        public string Country { get; set; }
        public string Locality { get; set; }
        public string District { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public string Housing { get; set; }
        public string Room { get; set; }
        public string Build { get; set; }
        public int? Location { get; set; }
        public bool IsForeigner { get; set; }
        public bool IsHomeless { get; set; }
        public int PeopleId { get; set; }
        public bool WithoutDoc { get; set; }
    }
}
