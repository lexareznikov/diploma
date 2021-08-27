using Demography.Domain.Classes;
using Demography.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.MapperConfig
{
    public class ClinicConfig
    {
        public ClinicViewModel ClinicToClinicViewModel(Clinic clinic)
        {

            return new ClinicViewModel
            {
                Email = clinic.Email,
                Fax = clinic.FAX,
                FullNameClinic = clinic.Name,
                ShortNameClinic = clinic.ShortName,
                INN = clinic.INN,
                OGRN = clinic.OGRN,
                Okpo = clinic.Okpo,
                Phone = clinic.Phone,
                Build = clinic.Build,
                Country = clinic.Country,
                District = clinic.District,
                House = clinic.House,
                Locality = clinic.Locality,
                Region = clinic.Region,
                DirectorId = clinic.DirectorId,
                Street = clinic.Street
            };
        }

        public Clinic ClinicViewModelToClinic(Clinic clinic, ClinicViewModel model)
        {
            clinic.Build = model.Build;
            clinic.Country = model.Country;
            clinic.District = model.District;
            clinic.Email = model.Email;
            clinic.DirectorId = model.DirectorId;
            clinic.FAX = model.Fax;
            clinic.House = model.House;
            clinic.INN = model.INN;
            clinic.Locality = model.Locality;
            clinic.Name = model.FullNameClinic;
            clinic.OGRN = model.OGRN;
            clinic.Okpo = model.Okpo;
            clinic.Phone = model.Phone;
            clinic.Region = model.Region;
            clinic.ShortName = model.ShortNameClinic;
            clinic.Street = model.Street;
            clinic.ActualAddress = model.LegalAddress;
            return clinic;
        }

    }
}
