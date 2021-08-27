using Demography.WinForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Models
{
    public class ClinicViewModel
    {

        public ClinicViewModel(Clinic form)
        {
            FullNameClinic = form.FullNameClinic;
            ShortNameClinic = form.ShortNameClinic;
            OGRN = form.OGRN;
            INN = form.INN;
            Okpo = form.Okpo;
            Phone = form.Phone;
            Fax = form.Fax;
            Email = form.Email;
            Country = form.Country;
            Locality = form.Locality;
            District = form.District;
            Region = form.Region;
            Street = form.Street;
            House = form.House;
            Build = form.Build;
            DirectorId = form.DirectorId;
            var fulltext = string.Empty;
            if(!string.IsNullOrEmpty(Region))
            {
                fulltext = Region + ",";
            }
            if (!string.IsNullOrEmpty(District))
            {
                fulltext = fulltext + District + ",";
            }
            if (!string.IsNullOrEmpty(Locality))
            {
                fulltext = fulltext + Locality + ",";
            }
            if (!string.IsNullOrEmpty(Street))
            {
                fulltext = fulltext + Street + ",";
            }
            if (!string.IsNullOrEmpty(House))
            {
                fulltext = fulltext + House + ",";
            }
            if (!string.IsNullOrEmpty(Build))
            {
                fulltext = fulltext + Build ;
            }
            fulltext = fulltext.Trim(new Char[] { ' ', ',' });
            LegalAddress = fulltext;
        }


               
        public ClinicViewModel()
        {

        }
        public string FullNameClinic { get; set; }
        public string ShortNameClinic { get; set; }
        public string OGRN { get; set; }

        public string INN { get; set; }

        public string Okpo { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }



        public string Country { get; set; }
        public string Locality { get; set; }
        public string District { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Build { get; set; }
        public int? DirectorId { get; set; }
        public string LegalAddress { get; set; }
    }
}
