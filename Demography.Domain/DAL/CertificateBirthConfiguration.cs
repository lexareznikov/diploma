using Demography.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.Domain.DAL
{
    public class CertificateBirthConfiguration : EntityTypeConfiguration<CertificateBirth>
    {
        public CertificateBirthConfiguration()
        {
            HasRequired(p => p.DoctorPost).WithMany().HasForeignKey(p => new { p.DoctorPostId, p.DoctorPostVersion });

        }
    }
}
