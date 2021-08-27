using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Demography.Domain.Classes.Nsi;

namespace Demography.Domain.Classes
{
    [Table("user", Schema = "main")]
    public class User
    {
        public User()
        {
            UserClinics = new HashSet<UserClinic>();
            UserRoles = new HashSet<UserRole>();
           
            IndividualPermissions = new HashSet<Permission>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("work_phone")]
        public string WorkPhone { get; set; }

        [Column("lastname")]
        public string LastName { get; set; }

        [Column("firstname")]
        public string FirstName { get; set; }

        [Column("middlename")]
        public string MiddleName { get; set; }

        [Column("snils")]
        public string Snils { get; set; }

        [Column("profile_type_id")]
        public int? ProfileTypeId { get; set; }

        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        [Column("birth_date")]
        public DateTime? BirthDate { get; set; }

        

        [Column("sex_id")]
        public int? SexId { get; set; }

        [Column("inn")]
        public string INN { get; set; }

        [Column("last_login_date")]
        public DateTime? LastLoginDate { get; set; }
        [Column("last_exit_date")]
        public DateTime? LastExitDate { get; set; }

        [Column("reg_status")]
        public int StatusId { get; set; }
        [Column("secret_word")]
        public string SecterWord { get; set; }

        [Column("comment")]
        public string Comment { get; set; }

        [Column("bid_role_id")]
        public int? BidRoleId { get; set; }

        [Column("birth_place")]
        public string BirthPlace { get; set; }

        [Column("document_id")]
        public int? DocumentId { get; set; }
        [Column("position_code")]
        public int? PositionCode { get; set; }
        [Column("position_version")]
        public string PositionVersion { get; set; }

      

        [ForeignKey("DocumentId")]
        public virtual Document Document { get; set; }

        public virtual ICollection<UserClinic> UserClinics { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Permission> IndividualPermissions { get; set; }

        public List<Permission> GetPermissions() {
            
            var list = new List<Permission>();
            foreach (var role in GetRoles()){
                list.AddRange(role.Permissions);
            }

            if(ProfileTypeId != null)
                list.AddRange(IndividualPermissions);
            return list.Distinct().ToList();
        }

        public List<Role> GetRoles()
        {
            var list = new List<Role>();
            list.AddRange(UserRoles.Select(it => it.Role).Where(it => it.ProfileTypeId == ProfileTypeId));//it.ProfileTypeId == null || 
            return list.Distinct().ToList();
        }

        public List<Role> GetRolesWithoutRestrictionProfile()
        {
            return UserRoles.Select(it => it.Role).ToList();
        }

        public string Name => $"{LastName} {FirstName} {MiddleName}";

        public string NameShort => $"{LastName} {FirstName.Substring(0, 1)}.{(string.IsNullOrEmpty(MiddleName) ? "" : MiddleName.Substring(0, 1) + ".")}";
    }
}
