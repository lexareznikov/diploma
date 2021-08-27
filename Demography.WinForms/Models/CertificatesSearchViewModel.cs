using Demography.WinForms.Views.CertificateBirth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Models
{
    public class CertificatesSearchViewModel
    {
        public CertificatesSearchViewModel(ListCertificate form)
        {
            CreateDateWith = form.CreateDateWith;
            CreateDateOn = form.CreateDateOn;
            IssueDateWith = form.IssueDateWith;
            IssueDateOn = form.IssueDateOn;
            StatusId = form.StatusId;
            FirstName = form.FirstName;
            LastName = form.LastName;
            MiddleName = form.MiddleName;
            Number = form.Number;
        }

        public int? StatusId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? CreateDateOn { get; set; }
        public DateTime? CreateDateWith { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public DateTime? IssueDateWith { get; set; }
        public DateTime? IssueDateOn { get; set; }

    }
}
