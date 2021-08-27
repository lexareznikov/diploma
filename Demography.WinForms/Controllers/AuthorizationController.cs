using Demography.BusinessLayer.Utility;
using Demography.Domain.Classes;
using Demography.Infrastructure.Domain;
using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Extensions;
using Demography.Infrastructure.Utility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demography.WinForms.Controllers
{
    public class AuthorizationController
    {
        private IUnitOfWork _unitOfWork;
        public AuthorizationController()
        {
            _unitOfWork = Program.GetUnitOfWork();
        }

        public bool LogIn(string email, string password)
        {
            var user = _unitOfWork.Users.All()
                .Include(x => x.UserClinics.Select(y => y.Clinic))
                .Include(x => x.IndividualPermissions)
                .Where(x => string.Equals(x.Email, email))
                .FirstOrDefault();
            _unitOfWork.Users.Reload(user);
            if (user != null && Crypto.VerifyMd5Hash(password, user.Password))
            {
                if (user.ProfileTypeId == null)
                {
                    user.ProfileTypeId = _unitOfWork.UserRoles.Filter(x => x.UserId == user.Id).Select(x => x.Role.ProfileTypeId).FirstOrDefault();
                }
                CurrentUser.Clinics = user.UserClinics.Select(x => x.Clinic).FirstOrDefault();
                CurrentUser.CreatedDate = user.CreatedDate;
                CurrentUser.Email = user.Email;
                CurrentUser.LastName = user.LastName;
                CurrentUser.FirstName = user.FirstName;
                CurrentUser.MiddleName = user.MiddleName;
                CurrentUser.Id = user.Id;
                CurrentUser.AccesAlowed = user.StatusId == (int)UserRegStatus.AccessAllowed;
                CurrentUser.IndividualPermissions = user.IndividualPermissions.ToList();
                CurrentUser.LastLoginDate = user.LastLoginDate;
                CurrentUser.Password = user.Password;
                CurrentUser.Phone = user.Phone;
                CurrentUser.ProfileTypeId = user.ProfileTypeId;
                CurrentUser.Roles = user.GetRoles();
                CurrentUser.Permissions = user.GetPermissions();
                CurrentUser.RolesWithoutRestrictionProfile = user.GetRolesWithoutRestrictionProfile();

                if (CurrentUser.AccesAlowed)
                {
                    user.LastLoginDate = DateTime.Now;
                    _unitOfWork.Users.AddOrUpdate(user);
                }
                _unitOfWork.Commit();

                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsSetPassword(string email, string password)
        {
            try
            {
                var user = _unitOfWork.Users.All()
                    .Include(x => x.UserClinics.Select(y => y.Clinic))
                    .Include(x => x.IndividualPermissions)
                    .Where(x => string.Equals(x.Email, email))
                    .FirstOrDefault();
                _unitOfWork.Users.Reload(user);

                if (Crypto.VerifyMd5Hash(password, user.SecterWord))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }



    }
}
