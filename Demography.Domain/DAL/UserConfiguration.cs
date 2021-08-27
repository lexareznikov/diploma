using System.Data.Entity.ModelConfiguration;
using Demography.Domain.Classes;

namespace Demography.Domain.DAL
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasRequired(p => p.Position).WithMany().HasForeignKey(p => new { p.PositionCode, p.PositionVersion });
            HasRequired(p => p.Speciality).WithMany().HasForeignKey(p => new { p.SpecialityCode, p.SpecialityVersion });
            HasRequired(p => p.Subdivision).WithMany().HasForeignKey(p => new { p.SubdivCode, p.SubdivVersion });
            HasRequired(p => p.Department).WithMany().HasForeignKey(p => new { p.DepartmentCode, p.DepartmentVersion });
        }
    }
}
