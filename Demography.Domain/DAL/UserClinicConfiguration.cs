using System.Data.Entity.ModelConfiguration;
using Demography.Domain.Classes;

namespace Demography.Domain.DAL
{
    public class UserClinicConfiguration : EntityTypeConfiguration<UserClinic>
    {
        public UserClinicConfiguration()
        {
            HasRequired(p => p.Position).WithMany().HasForeignKey(p => new { p.PostCode, p.PostVersion });
        }
    }
}
