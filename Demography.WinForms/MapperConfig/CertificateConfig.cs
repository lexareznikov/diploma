using Demography.Domain.Classes;
using Demography.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.MapperConfig
{
    public class CertificateConfig
    {

        public CertificateBirth CertificateEditToCertihicateBirth(CertificateBirth certificate, CertificateEditViewModel model)
        {
            certificate.PeopleId = model.PeopleId;

            certificate.Series = model.Series;
            certificate.Number = model.Number;
            certificate.StatusId = model.StatusId;
            certificate.CreatedDate = model.CreateDate.Value;
            certificate.DoctorId = model.UserId.Value;
            certificate.DoctorPostId = (int)model.UserPostId.Split('|').Select(x => Convert.ToInt32(x)).FirstOrDefault();
            certificate.DoctorPostVersion = model.UserPostId.Split('|').LastOrDefault();
            certificate.ProfessionAcceptBirthId = model.BirthAcceptId;
            certificate.DirectorClinicId = model.DirectorId;
            certificate.Id = (int)model.CertificateId;

            certificate.RecipientLastname = model.RecipientLastname;
            certificate.RecipientFirstname = model.RecipientFirstname;
            certificate.RecipientMiddlename = model.RecipientMiddlename;
            certificate.RecipientRelationshipChildId = model.RecipientRelationshipTypeId;
            certificate.RecipientDoctypeId = model.RecipientDocTypeId;
            certificate.RecipientDocWhomIssued = model.RecipientDocOrgName;
            certificate.RecipientDocSeries = model.RecipientDocSeries;
            certificate.RecipientDocNumber = model.RecipientDocNumber;
            certificate.ClinicId = model.ClinicId;

            certificate.LastName = model.LastName;
            certificate.Birthday = model.Birthdate;
            certificate.SexId = model.SexId.Value;
            certificate.WeightChildBirth = model.WeightChild;
            certificate.LengthBodyChildBirth = model.LengthBodyChild;
            certificate.ChildbirthOnefetalUnderAccount = model.ChildbirthOneFetalUnderAccount;
            certificate.ChildbirthPolycarpousUnderAccount = model.ChildBirthPolycarpousUnderAccount;
            certificate.ChildrenBorn = model.ChildrenBorn;
            if(certificate.AddressPlaceBirth!=null)
            {
                certificate.AddressPlaceBirth.Region = model.Region;
                certificate.AddressPlaceBirth.Locality = model.Locality;
                certificate.AddressPlaceBirth.Location = model.Location;
            }
            else
            {
                certificate.AddressPlaceBirth = new Address { Region = model.Region, Locality = model.Locality,Location = model.Location};

            }


            
            certificate.MotherBirthday = model.MotherBirthdate;
            certificate.IsMotherForeigner = model.MotherIsForeigner;
            certificate.MotherFirstname = model.MotherFirstName;
            certificate.MotherLastName = model.MotherLastName;
            certificate.MotherMiddlename = model.MotherMiddleName;
            certificate.IsMotherHomeless = model.MotherIsHomeless;
            certificate.MotherEducationId = model.MotherEducationId;
            certificate.MotherEmploymentId = model.MotherEmploymentId;
            certificate.ChildUnderAccount = model.ChildUnderAccount;
            certificate.FirstTurnoutDoctor = model.FirstTournoutDoctor;
            certificate.PlaceChildbirthId = model.PlaceChildbirthId;
            certificate.MotherFamilyStatusId = model.MotherFamilyStatusId;
            if (!model.MotherIsForeigner && !model.MotherIsHomeless)
            {
                if (certificate.AddressPlaceLivingMother == null)
                {
                    certificate.AddressPlaceLivingMother = new Address
                    {
                        Country = model.MotherCountry,
                        Locality = model.MotherLocality,
                        District = model.MotherDistrict,
                        Region = model.MotherRegion,
                        Street = model.MotherStreet,
                        House = model.MotherHouse,
                        Flat = model.MotherFlat,
                        
                        Location = model.MotherLocation
                    };
                }
                else
                {
                    certificate.AddressPlaceLivingMother.Country = model.MotherCountry;
                    certificate.AddressPlaceLivingMother.Locality = model.MotherLocality;
                    certificate.AddressPlaceLivingMother.District = model.MotherDistrict;
                    certificate.AddressPlaceLivingMother.Region = model.MotherRegion;
                    certificate.AddressPlaceLivingMother.Street = model.MotherStreet;
                    certificate.AddressPlaceLivingMother.House = model.MotherHouse;
                    certificate.AddressPlaceLivingMother.Flat = model.MotherFlat;
                    certificate.AddressPlaceLivingMother.Location = model.MotherLocation;
                }
            }
            else
            {
                certificate.AddressPlaceLivingMother = null;
                certificate.AddressPlaceLivingMotherId = null;
            }

            return certificate;
        }
        public CertificateEditViewModel PeopleToCertificateEditViewModel(People people)
        {
            return new CertificateEditViewModel
            {
                MotherBirthdate = people.BirthDate,
            MotherCountry = people.PlaceLiving?.Country,
            MotherDistrict = people.PlaceLiving?.District,
            MotherFirstName = people.FirstName,
            MotherMiddleName = people.MiddleName,
            MotherLastName = people.LastName,
            MotherFlat = people.PlaceLiving?.Flat,
            MotherHouse = people.PlaceLiving?.House,
            MotherIsForeigner = people.IsForeigner,
            MotherIsHomeless = people.IsHomeless,
            MotherLocality = people.PlaceLiving?.Locality,
            MotherLocation = people.PlaceLiving?.Location,
            MotherRegion = people.PlaceLiving?.Region,
            MotherStreet = people.PlaceLiving?.Street,
           
        };

        }
        public CertificateEditViewModel CertificateBirthToCertificateEditViewModel(CertificateBirth certificate)
        {
            return new CertificateEditViewModel {

                MotherBirthdate = certificate.MotherBirthday,
                MotherCountry = certificate.AddressPlaceLivingMother?.Country,
                MotherDistrict = certificate.AddressPlaceLivingMother?.District,
                MotherFirstName = certificate.MotherFirstname,
                MotherMiddleName = certificate.MotherMiddlename,
                MotherLastName = certificate.MotherLastName,
                MotherFlat = certificate.AddressPlaceLivingMother?.Flat,
                MotherHouse = certificate.AddressPlaceLivingMother?.House,
                MotherIsForeigner = certificate.IsMotherForeigner,
                MotherIsHomeless = certificate.IsMotherHomeless,
                MotherLocality = certificate.AddressPlaceLivingMother?.Locality,
                MotherLocation = certificate.AddressPlaceLivingMother?.Location,
                MotherRegion = certificate.AddressPlaceLivingMother?.Region,
                MotherStreet = certificate.AddressPlaceLivingMother?.Street,
                MotherEducationId=certificate.MotherEducationId,
                MotherEmploymentId = certificate.MotherEmploymentId,
                MotherFamilyStatusId = certificate.MotherFamilyStatusId,
                PlaceChildbirthId = certificate.PlaceChildbirthId,
                ChildUnderAccount = certificate.ChildUnderAccount,
                FirstTournoutDoctor = certificate.FirstTurnoutDoctor,

                RecipientDocNumber = certificate.RecipientDocNumber,
                RecipientDocOrgName = certificate.RecipientDocWhomIssued,
                RecipientDocSeries = certificate.RecipientDocSeries,
                RecipientDocTypeId = certificate.RecipientDoctypeId,
                RecipientFirstname = certificate.RecipientFirstname,
                RecipientLastname = certificate.RecipientLastname,
                RecipientMiddlename = certificate.RecipientMiddlename,
                RecipientRelationshipTypeId = certificate.RecipientRelationshipChildId,

                UserId = certificate.DoctorId,
                UserPostId = certificate.DoctorPostId + "|" + certificate.DoctorPostVersion,
                StatusId = certificate.StatusId,
                CreateDate = certificate.CreatedDate,
                Series = certificate.Series,
                Number = certificate.Number,
                DirectorId = certificate.DirectorClinicId,
                ClinicId = certificate.ClinicId,
                BirthAcceptId = certificate.ProfessionAcceptBirthId,
                CertificateId = certificate.Id,


                LastName = certificate.LastName,
                SexId = certificate.SexId,
                Birthdate = certificate.Birthday,
                WeightChild = certificate.WeightChildBirth,
                LengthBodyChild = certificate.LengthBodyChildBirth,
                ChildrenBorn = certificate.ChildrenBorn,
                ChildbirthOneFetalUnderAccount = certificate.ChildbirthOnefetalUnderAccount,
                ChildBirthPolycarpousUnderAccount = certificate.ChildbirthPolycarpousUnderAccount,
                Locality= certificate.AddressPlaceBirth.Locality,
                Location = certificate.AddressPlaceBirth.Location,
                PeopleId = certificate.PeopleId,
                Region = certificate.AddressPlaceBirth.Region,
                IsCreate = false




        };
        }
    }
}
