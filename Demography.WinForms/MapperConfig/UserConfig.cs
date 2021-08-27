using Demography.Domain.Classes;
using Demography.Infrastructure.Enums;
using Demography.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.MapperConfig
{
    public class UserConfig
    {
        public User RegistrationModelToUser(RegistrationModel registrationModel)
        {
            var user = new User();
            user.BidRoleId = registrationModel.BidRole;
            user.BirthDate = registrationModel.BirthDate;
            user.Comment = registrationModel.Comment;
            user.CreatedDate = DateTime.Now;
            user.Email = registrationModel.Email;
            user.FirstName = registrationModel.FirstName;
            user.INN = registrationModel.INN;
            user.LastName = registrationModel.LastName;
            user.MiddleName = registrationModel.MiddleName;
            user.StatusId = (int)UserRegStatus.OnReview;
            user.Phone = registrationModel.Phone;
            user.BirthPlace = registrationModel.BirthPlace;
            user.WorkPhone = registrationModel.WorkPhone;
            user.Snils = registrationModel.Snils;
            user.SexId = registrationModel.Sex;
            user.PositionCode = (int?)registrationModel.Position.Split('|').Select(x => Convert.ToInt32(x)).FirstOrDefault();
            user.PositionVersion = registrationModel.Position.Split('|').LastOrDefault();
            if (registrationModel.DocTypeId.HasValue)
            {
                user.Document = new Document();
                user.Document.ExpirationDateTime = registrationModel.DocDateOn;
                user.Document.IssueDateTime = registrationModel.DocDateWith;
                user.Document.Number = registrationModel.DocNumber;
                user.Document.Issuer = registrationModel.DocOrgName;
                user.Document.Series = registrationModel.DocSeries;
                user.Document.DocTypeId = registrationModel.DocTypeId;
            }
            user.UserClinics.Add(new UserClinic()
            {
                ClinicId = (int)registrationModel.Clinic,
                PostCode = (int?)registrationModel.Position.Split('|').Select(x => Convert.ToInt32(x)).FirstOrDefault(),
                PostVersion = registrationModel.Position.Split('|').LastOrDefault()
            });
            user.UserRoles.Add(new UserRole { RoleId = registrationModel.BidRole.Value });
            return user;
        }
        public UserEditViewModel UserToUserEditViewModel(User user)
        {
            return new UserEditViewModel
            {
                Comment = user.Comment,
                Email = user.Email,
                FirstName = user.FirstName,
                INN = user.INN,
                LastName = user.LastName,
                MiddleName = user.MiddleName,
                Phone = user.Phone,
                SexId = user.SexId,
                Snils = user.Snils,
                WorkPhone = user.WorkPhone,
                DocId = user.Document?.Id,
                DocDateOn = user.Document?.ExpirationDateTime,
                DocDateWith = user.Document?.IssueDateTime,
                DocNumber = user.Document?.Number,
                DocOrgName = user.Document?.Issuer,
                DocSeries = user.Document?.Series,
                DocTypeId = user.Document?.DocTypeId,
                BirthDate = user.BirthDate,
                BidRoleId = user.BidRoleId,
                BirthPlace = user.BirthPlace,
                StatusId = user.StatusId

            };
        }
        public User UserEditViewModelToUser(User user, UserEditViewModel model)
        {

            user.Comment = model.Comment;
            user.Email = model.Email;
            user.FirstName = model.FirstName;
            user.INN = model.INN;
            user.LastName = model.LastName;
            user.MiddleName = model.MiddleName;
            user.Phone = model.Phone;
            user.SexId = model.SexId;
            user.Snils = model.Snils;
            user.WorkPhone = model.WorkPhone;
            user.BirthDate = model.BirthDate;
            user.BidRoleId = model.BidRoleId;
            user.BirthPlace = model.BirthPlace;
            user.StatusId = model.StatusId.Value;
            if (model.DocTypeId.HasValue)
            {
                if (model.DocId == 0 || model.DocId == null)
                {
                    user.Document = new Document();
                }
                else
                {
                    user.Document.Id = model.DocId.Value;
                }
                user.Document.ExpirationDateTime = model.DocDateOn;
                user.Document.IssueDateTime = model.DocDateWith;
                user.Document.Number = model.DocNumber;
                user.Document.Issuer = model.DocOrgName;
                user.Document.Series = model.DocSeries;
                user.Document.DocTypeId = model.DocTypeId;
            }
            return user;


        }
        //public UserAccountViewModel UserToUserAccountViewModel(User user)
        //{
        //    return new UserAccountViewModel
        //    {
        //        Comment=user.Comment,
        //        Email=user.Email,
        //        FirstName=user.FirstName,
        //        INN=user.INN,
        //        LastName=user.LastName,
        //        MiddleName=user.MiddleName,
        //        Phone=user.Phone,
        //        ProfileTypeId=user.ProfileTypeId.Value,
        //        Rights= string.Join(", ", user.UserRoles.Select(x => x.Role.Permissions)),
        //        Roles= string.Join(", ", user.UserRoles.Select(x => x.Role.Name)),
        //        SexId=user.SexId,
        //        Snils=user.Snils,
        //        WorkPhone=user.WorkPhone
        //    };
        //}
    }
}
