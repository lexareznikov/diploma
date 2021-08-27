using Demography.Domain.Classes;
using Demography.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.MapperConfig
{
    public class BlanksConfig
    {

        public ExpenseBlanksViewModel CertificateToExpenseBlanksViewModel(CertificateBirth certificate)
        {
            return new ExpenseBlanksViewModel
            {
                Number = certificate.Number,
                Series = certificate.Series,
                StatusId = certificate.StatusId
            };
        }
    }
}
