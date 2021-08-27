using AutoMapper.QueryableExtensions;
using Demography.BusinessLayer.Utility;
using Demography.Domain.Classes;
using Demography.Infrastructure.Domain;
using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Utility;
using Demography.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Controllers
{
    public class UserController
    {
        private IUnitOfWork _unitOfWork;
        public UserController()
        {
            _unitOfWork = Program.GetUnitOfWork();
        }
        public IQueryable<User> GetById(int id)
        {
            return _unitOfWork.Users.Filter(it => it.Id == id)
                                    .Include(it => it.IndividualPermissions)
                                    .Include(it => it.UserRoles.Select(y => y.Role.Permissions))
                                    .Include(it => it.UserClinics.Select(y => y.Clinic))
                                    .Include(it => it.UserClinics.Select(y => y.Position))
                                    .Include(it => it.Document);

        }
        public void SetPassword(string email, string password)
        {
            var user = _unitOfWork.Users.Filter(x => x.Email == email).FirstOrDefault();
            if (user != null)
            {
                Reload(user);
                user.Password = Crypto.GetMd5Hash(password);
                AddOrUpdateUser(user);
            }
        }
        public List<User> GetListUsers(UserSearchViewModel search)
        {
            var query = _unitOfWork.Users.All().Include(x => x.UserRoles).AsNoTracking();
            if (!string.IsNullOrEmpty(search.FirstName))
            {
                query = query.Where(x => x.FirstName.ToUpper().Contains(search.FirstName.ToUpper()));
            }
            if (!string.IsNullOrEmpty(search.LastName))
            {
                query = query.Where(x => x.LastName.ToUpper().Contains(search.LastName.ToUpper()));
            }
            if (!string.IsNullOrEmpty(search.MiddleName))
            {
                query = query.Where(x => x.MiddleName.ToUpper().Contains(search.MiddleName.ToUpper()));
            }
            if (search.RoleId != null)
            {
                query = query.Where(x => x.UserRoles.Any(y => y.RoleId == search.RoleId));
            }
            if (search.StatusId != null)
            {
                query = query.Where(x => x.StatusId == search.StatusId);
            }

            return query.ToList();
        }
        public void AddOrUpdateUser(User user)
        {
            _unitOfWork.Users.AddOrUpdate(user);
            _unitOfWork.Commit();
        }
        public void RefillCurrentUser(User user)
        {
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
        }
        public bool IsExistSnils(string snils)
        {
            var user = _unitOfWork.Users.All().Where(x => x.Snils == snils).AsNoTracking().FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            return false;
        }

        public void UpdateProfile(int ProfileTypeId)
        {
            var user = GetById(CurrentUser.Id).FirstOrDefault();
            _unitOfWork.Users.Reload(user);
            user.ProfileTypeId = ProfileTypeId;
            CurrentUser.ProfileTypeId = ProfileTypeId;
            CurrentUser.Permissions = user.GetPermissions();
            CurrentUser.Roles = user.GetRoles();
            CurrentUser.RolesWithoutRestrictionProfile = user.GetRolesWithoutRestrictionProfile();
            _unitOfWork.Users.AddOrUpdate(user);
            _unitOfWork.Commit();
        }
        public void Reload(User user)
        {
            _unitOfWork.Users.Reload(user);
        }
        public void DeletePosition(int id)
        {
            _unitOfWork.UserClinics.Delete(id);
            _unitOfWork.Commit();
        }
        public bool AddPosition(int userId, UserClinicViewModel model)
        {
            var errorMessage = string.Empty;
            var user = GetById(userId).FirstOrDefault();
            _unitOfWork.Users.Reload(user);
            var positionId = model.Position.Split('|').Select(x => Convert.ToInt32(x)).FirstOrDefault();
            var positionVersion = model.Position.Split('|').LastOrDefault();
            if (!IsExistUserClinic(user.Id, model.ClinicId, positionId, positionVersion))
            {
                user.UserClinics.Add(new UserClinic { ClinicId = model.ClinicId, PostCode = positionId, PostVersion = positionVersion });
                _unitOfWork.Users.AddOrUpdate(user);
                _unitOfWork.Commit();
                if (CurrentUser.Id == user.Id)
                {
                    RefillCurrentUser(user);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SaveExitDate(int id)
        {
            var user = GetById(id).FirstOrDefault();
            Reload(user);
            user.LastExitDate = DateTime.Now;
            AddOrUpdateUser(user);
        }
        public bool AddRole(int userId, int roleId)
        {

            //var user = GetById(userId).FirstOrDefault();
            //_unitOfWork.Users.Reload(user);

            if (!IsExistUserRoles(userId, roleId))
            {
                var role = new UserRole { RoleId = roleId,UserId = userId };
                _unitOfWork.UserRoles.AddOrUpdate(role);
                _unitOfWork.Commit();
                if (CurrentUser.Id == userId)
                {
                    var user = GetById(userId).FirstOrDefault();
                    _unitOfWork.Users.Reload(user);
                    RefillCurrentUser(user);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsExistUserClinic(int userId, int clinicId, int positionCode, string positionVersion)
        {
            return _unitOfWork.UserClinics.Filter(x => x.UserId == userId && x.ClinicId == clinicId && x.PostCode == positionCode && x.PostVersion == positionVersion).AsNoTracking().FirstOrDefault() != null;
        }
        public bool IsExistEmail(string email)
        {
            return _unitOfWork.Users.Filter(x=>x.Email == email).AsNoTracking().FirstOrDefault() != null;
        }
        private bool IsExistUserRoles(int userId, int roleId)
        {
            return _unitOfWork.UserRoles.Filter(x => x.UserId == userId && x.RoleId == roleId).AsNoTracking().FirstOrDefault() != null;
        }
        public void DeleteRole(int id)
        {
            _unitOfWork.UserRoles.Delete(id);
            _unitOfWork.Commit();
        }
        public bool IsExistInn(string inn)
        {
            var user = _unitOfWork.Users.All().Where(x => x.INN == inn).AsNoTracking().FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            return false;
        }
        public bool DeniedAccess(int UserId)
        {
            try
            {
                var user = GetById(UserId).FirstOrDefault();
                _unitOfWork.Users.Reload(user);
                user.StatusId = (int)UserRegStatus.AccessDenied;
                AddOrUpdateUser(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AllowAccess(int UserId)
        {
            try
            {
                var user = GetById(UserId).FirstOrDefault();
                _unitOfWork.Users.Reload(user);
                user.StatusId = (int)UserRegStatus.AccessAllowed;
                
                SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 25)
                {
                    Credentials = new NetworkCredential("lexareznikov@mail.ru", "4pFQTjqAdTLKTDi8heeM")//4pFQTjqAdTLKTDi8heeM
                };
                MailMessage Message = new MailMessage
                {
                    From = new MailAddress("lexareznikov@mail.ru")
                };
                var secterCodeInMD5 = Crypto.CreatePassword(10);
                Message.To.Add(new MailAddress(user.Email));
                Message.Subject = "МИС \"Аист\"";
                Smtp.EnableSsl = true;
                Message.Body = $"Здравствуйте, Вам предоставили доступ в МИС \"Аист\". Для входа в систему, Вам нужно ввести свой логин (почту) и кодовое слово {secterCodeInMD5} в поле 'пароль'. Вам откроется форма, в которой нужно задать пароль! Для смены пароля использовать этот код еще раз. С уважением, МИС \"Аист\"";
                    Smtp.Send(Message);
                user.SecterWord = Crypto.GetMd5Hash(secterCodeInMD5);
                AddOrUpdateUser(user);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
