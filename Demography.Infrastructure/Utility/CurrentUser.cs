using System.Collections.Generic;
using System.Linq;
using Demography.Domain.Classes;
using Demography.Infrastructure.Enums;
using System;

namespace Demography.Infrastructure.Utility
{
    public static class CurrentUser
    {
       
        public static int Id { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        public static  string Phone { get; set; }
        public static string LastName { get; set; }
        public static bool AccesAlowed { get; set; }
        public static string FirstName { get; set; }
        public static string MiddleName { get; set; }
        public static bool IsAdmin { get { return Roles != null && Roles.Any(it => it.Alies == "Admin") && ProfileTypeId == (int)ProfileTypeApp.Admin; }}
       
      
        public static int? ProfileTypeId { get; set; }
        public static bool IsLocked { get; set; }
        public static DateTime? LastLoginDate { get; set; }
        public static DateTime CreatedDate { get; set; }
        public static List<Role> Roles { get; set; }
        public static List<Permission> Permissions { get; set; }
        public static Clinic Clinics { get; set; } = null;
        public static List<Role> RolesWithoutRestrictionProfile { get; set; }
        public static List<Permission> IndividualPermissions { get; set; }
        
       
        public static bool HasPermission(params string [] permissions)
        {
            if (permissions == null)
                return false;

            if (IsAdmin)
                return true;
            
            return Permissions.Any(it => permissions.Any(z => z == it.Alias));
        }

        public static bool HasPermission(bool checkAdmin = true, params string[] permissions)
        {
            if (permissions == null)
                return false;

            if (checkAdmin && IsAdmin)
                return true;

            return Permissions.Any(it => permissions.Any(z => z == it.Alias));
        }
        /// <summary>
        /// Проверка роли
        /// </summary>
        /// <param name="roleApp">Роли</param>
        /// <returns></returns>
        public static bool HasRoles(RoleApp roleApp, bool checkAdmin = true)
        {
            if (checkAdmin && IsAdmin)
                return true;

            if (Roles == null)
                return false;

            foreach (Role role in Roles){
                    var bFound = roleApp.HasFlag((RoleApp)role.Flag);
                    if (bFound)
                        return true;
            }

            return false;
        }

        //public static List<ProfileTypeApp> AvailableProfiles
        //{
        //    get
        //    {
        //        var list = RolesWithoutRestrictionProfile.Where(it => it.ProfileTypeId != null).Select(it => it.ProfileTypeId).Distinct().Select(it => (ProfileTypeApp)it.Value).ToList();
        //        if (list.Contains(ProfileTypeApp.Checking)){
        //            if (Clinics.All(it => it.IsWithoutRoleChecking)){
        //                list.Remove(ProfileTypeApp.Checking);
        //                if (ProfileTypeId == (int)ProfileTypeApp.Checking)
        //                    ProfileTypeId = list.Count > 1 ? (int?)list.FirstOrDefault() : null;
        //            }
        //        }
        //        return list;
        //    }
        //}

        //public static bool IsShowProfile()
        //{
        //    return AvailableProfiles.Count > 1;
        //}

    }
}