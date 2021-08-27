using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demography.Domain.Classes
{
    [Table("certificate_birth_remark")]
    public class CertificateBirthRemark : Remark
    {
        [ForeignKey("CertificateId")]
        public virtual CertificateBirth Remark { get; set; }
    }
}