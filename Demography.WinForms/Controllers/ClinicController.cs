using Demography.Domain.Classes;
using Demography.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Controllers
{
    public class ClinicController
    {
        private IUnitOfWork _unitOfWork;
        public ClinicController()
        {
            _unitOfWork = Program.GetUnitOfWork();
        }
        public IQueryable<Clinic> GetAll ()
        {
            return _unitOfWork.Clinics.All();
        }
        public void Reload(Clinic clinic)
        {
            _unitOfWork.Clinics.Reload(clinic);
        }
        public int? GetDirector()
        {
            return _unitOfWork.Clinics.All().Select(x => x.DirectorId).FirstOrDefault();
        }
        public void AddOrUpdate (Clinic clinic)
        {
            _unitOfWork.Clinics.AddOrUpdate(clinic);
            _unitOfWork.Commit();
        }
    }
}
