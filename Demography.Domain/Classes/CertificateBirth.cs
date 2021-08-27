using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("certificate_birth")]
    public class CertificateBirth : Certificate
    {
        #region SnilsMissingReasonType
        //вынесено из certificate по причине ненужности в сертификате о смерти
        
       
        #endregion
        [Column("mother_family_status_id")]
        public int? MotherFamilyStatusId { get; set; }

        [Column("mother_education_id")]
        public int? MotherEducationId { get; set; }

       
        [Column("mother_employment_id")]
        public int? MotherEmploymentId { get; set; }

        

        [Column("weight_child_birth")]
        public int? WeightChildBirth { get; set; }

        [Column("child_under_account")]
        public int? ChildUnderAccount { get; set; }

       

        [Column("length_body_child_birth")]
        public int? LengthBodyChildBirth { get; set; }
        [Column("recipient_relationship_child_id")]
        public int? RecipientRelationshipChildId { get; set; }
       

        [Column("profession_accept_birth_id")]
        public int? ProfessionAcceptBirthId { get; set; }

        [Column("children_born")]
        public int? ChildrenBorn { get; set; }

        [Column("childbirth_onefetal_under_account")]
        public bool ChildbirthOnefetalUnderAccount { get; set; }

        [Column("childbirth_polycarpous_under_account")]
        public int? ChildbirthPolycarpousUnderAccount { get; set; }

        [Column("birthday")]
        public DateTime? Birthday { get; set; }

        [Column("first_turnout_doctor")]
        public int? FirstTurnoutDoctor { get; set; }

        [Column("place_childbirth_id")]
        public int? PlaceChildbirthId { get; set; }

        [Column("address_place_living_mother_id")]
        public int? AddressPlaceLivingMotherId { get; set; }

        [Column("address_place_birth_id")]
        public int? AddressPlaceBirthId { get; set; }
        [Column("is_mother_foreigner")]
        public bool IsMotherForeigner { get; set; }
        [ForeignKey("AddressPlaceLivingMotherId")]
        public virtual Address AddressPlaceLivingMother { get; set; }
        public virtual ICollection<CertificateBirthRemark> Remarks { get; set; }

        [ForeignKey("AddressPlaceBirthId")]
        public virtual Address AddressPlaceBirth { get; set; }

        [ForeignKey("MotherFamilyStatusId")]
        public virtual FamilyStatus MotherFamilyStatus { get; set; }

        [ForeignKey("MotherEducationId")]
        public virtual Education MotherEducation { get; set; }

        [ForeignKey("MotherEmploymentId")]
        public virtual Employment MotherEmployment { get; set; }


        [ForeignKey("PlaceChildbirthId")]
        public virtual PlaceChildbirth PlaceChildBirth { get; set; }

        [ForeignKey("ProfessionAcceptBirthId")]
        public virtual ProfessionAcceptBirth ProfessionAcceptBirth { get; set; }
        
        [ForeignKey("RecipientRelationshipChildId")]
        public virtual FamilyRelationship RecipientRelationship { get; set; }
    }
}