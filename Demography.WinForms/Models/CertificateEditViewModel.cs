using Demography.WinForms.Views.CertificateBirth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Models
{
    public class CertificateEditViewModel
    {
        public CertificateEditViewModel(EditCertificate form)
        {
            StatusId = form.StatusId.Value;
            Series = form.Series;
            Number = form.Number;
            CreateDate = form.CreateDate;
            UserId = form.UserId;
            UserPostId = form.UserPostId;
            BirthAcceptId = form.BirthAcceptId;
            DirectorId = form.DirectorId;
            RecipientLastname = form.RecipientLastname;
            RecipientFirstname = form.RecipientFirstname;
            RecipientMiddlename = form.RecipientMiddlename;
            RecipientRelationshipTypeId = form.RecipientRelationshipTypeId;
            RecipientDocTypeId = form.RecipientDocTypeId;
            RecipientDocSeries = form.RecipientDocSeries;
            RecipientDocNumber = form.RecipientDocNumber;
            RecipientDocOrgName = form.RecipientDocOrgName;
            LastName = form.LastName;
            Birthdate = form.Birthdate;
            SexId = form.SexId;
            WeightChild = form.WeightChild;
            LengthBodyChild = form.LengthBodyChild;
            ChildbirthOneFetalUnderAccount = form.ChildbirthOneFetalUnderAccount;
            ChildBirthPolycarpousUnderAccount = form.ChildBirthPolycarpousUnderAccount;
            ChildrenBorn = form.ChildrenBorn;
            Locality = form.Locality;
            Region = form.Region;
            Location = form.Location;
            MotherFirstName = form.MotherFirstName;
            MotherLastName = form.MotherLastName;
            MotherMiddleName = form.MotherMiddleName;
            FirstTournoutDoctor = form.FirstTournoutDoctor;
            ChildUnderAccount = form.ChildUnderAccount;
            MotherBirthdate = form.MotherBirthdate;
            MotherEducationId = form.MotherEducationId;
            PlaceChildbirthId = form.PlaceChildbirthId;
            MotherFamilyStatusId = form.MotherFamilyStatusId;
            MotherCountry = form.MotherCountry;
            MotherLocality = form.MotherLocality;
            MotherDistrict = form.MotherDistrict;
            MotherRegion = form.MotherRegion;
            MotherStreet = form.MotherStreet;
            MotherHouse = form.MotherHouse;
            MotherFlat = form.MotherFlat;
            MotherIsForeigner = form.MotherIsForeigner;
            MotherIsHomeless = form.MotherIsHomeless;
            PeopleId = form.PeopleId;
            MotherEmploymentId = form.MotherEmploymentId;
            CertificateId = form.CertificateId;
            IsCreate = form.IsCreate;
            ClinicId = form.ClinicId.Value;
            MotherLocation = form.MotherLocation;
        }
        public CertificateEditViewModel()
        {

        }


        public string Series { get; set; }
        public string Number { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserId { get; set; }
        public int StatusId { get; set; }
        public int ClinicId { get; set; }
        public string UserPostId { get; set; }
        public int? BirthAcceptId { get; set; }
        public int? DirectorId { get; set; }
        public string RecipientLastname { get; set; }
        public string RecipientFirstname { get; set; }
        public string RecipientMiddlename { get; set; }
        public int? RecipientRelationshipTypeId { get; set; }
        public int? RecipientDocTypeId { get; set; }
        public string RecipientDocSeries { get; set; }
        public string RecipientDocNumber { get; set; }
        public string RecipientDocOrgName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public int? SexId { get; set; }
        public int? WeightChild { get; set; }
        public int? LengthBodyChild { get; set; }
        public bool ChildbirthOneFetalUnderAccount { get; set; }
        public int? ChildBirthPolycarpousUnderAccount { get; set; }
        public int? ChildrenBorn { get; set; }
        public string Locality { get; set; }
        public string Region { get; set; }
        public int? Location { get; set; }
        public string MotherFirstName { get; set; }
        public string MotherLastName { get; set; }
        public string MotherMiddleName { get; set; }
        public int? FirstTournoutDoctor { get; set; }
        public int? ChildUnderAccount { get; set; }
        public DateTime? MotherBirthdate { get; set; }
        public int? MotherEducationId { get; set; }
        public int? MotherEmploymentId { get; set; }
        public int? PlaceChildbirthId { get; set; }
        public int? MotherFamilyStatusId { get; set; }
        public string MotherCountry { get; set; }
        public string MotherLocality { get; set; }
        public string MotherDistrict { get; set; }
        public string MotherRegion { get; set; }
        public string MotherStreet { get; set; }
        public string MotherHouse { get; set; }
        public string MotherFlat { get; set; }
        public bool MotherIsForeigner { get; set; }
        public bool MotherIsHomeless { get; set; }
        public int? PeopleId { get; set; }
        public int? CertificateId { get; set; }
        public bool IsCreate { get; set; }
        public int? MotherLocation { get; set; }
    }
}
