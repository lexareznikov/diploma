using Demography.Domain.Classes.Nsi;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    public abstract class Certificate
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("series")]
        public string Series { get; set; }

        [Column("number")]
        public string Number { get; set; }

        [Column("issuance_date")]
        public DateTime IssuanceDate { get; set; }
        
        [Column("lastname")]
        public string LastName { get; set; }

        [Column("firstname")]
        public string FirstName { get; set; }

        [Column("middlename")]
        public string MiddleName { get; set; }
        
        [Column("sex_id")]
        public int SexId { get; set; }

        [Column("mother_lastname")]
        public string MotherLastName { get; set; }

        [Column("mother_firstname")]
        public string MotherFirstname { get; set; }

        [Column("mother_middlename")]
        public string MotherMiddlename { get; set; }

        [Column("mother_birthday")]
        public DateTime? MotherBirthday { get; set; }
        [Column("status_id")]
        public int StatusId { get; set; }


        [Column("clinic_id")]
        public int ClinicId { get; set; }

        [Column("doctor_id")]
        public int DoctorId { get; set; }

        [Column("doctor_post_fed_id")]
        public int DoctorPostId { get; set; }

        [Column("doctor_post_fed_v")]
        public string DoctorPostVersion { get; set; }

        [Column("people_id")]
        public int? PeopleId { get; set; }
      

       

        [Column("director_clinic_id")]
        public int? DirectorClinicId { get; set; }

        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

       

        #region recipient

        [Column("recipient_lastname")]
        public string RecipientLastname { get; set; }

        [Column("recipient_firstname")]
        public string RecipientFirstname { get; set; }

        [Column("recipient_middlename")]
        public string RecipientMiddlename { get; set; }

       

        [Column("recipient_doctype_id")]
        public int? RecipientDoctypeId { get; set; }

        [Column("recipient_doc_series")]
        public string RecipientDocSeries { get; set; }

        [Column("recipient_doc_number")]
        public string RecipientDocNumber { get; set; }

        [Column("recipient_doc_whom_issued")]
        public string RecipientDocWhomIssued { get; set; }
        #endregion

        [Column("is_homeless")]
        public bool IsMotherHomeless { get; set; }

      
        [ForeignKey("DirectorClinicId")]
        public virtual User DirectorClinic { get; set; }
        
        [ForeignKey("ClinicId")]
        public virtual Clinic Clinic { get; set; }

        [ForeignKey("PeopleId")]
        public virtual People People { get; set; }

        [ForeignKey("DoctorPostId")]
        public virtual PositionFed00004 DoctorPost { get; set; }
        
        [ForeignKey("DoctorId")]
        public virtual User Doctor { get; set; }

        [ForeignKey("RecipientDoctypeId")]
        public virtual PeopleDocType RecipientDoctype { get; set; }
        public string NameShort => $"{LastName} {(string.IsNullOrEmpty(FirstName) ? "" : FirstName.Substring(0, 1) + ".")} {(string.IsNullOrEmpty(MiddleName) ? "" : MiddleName.Substring(0, 1) + ".")}";
        public string Name => $"{LastName} {FirstName} {MiddleName}";
    }
}