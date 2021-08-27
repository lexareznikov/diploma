using Demography.Domain.Classes;
using Demography.Infrastructure.Domain;
using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Utility;
using Demography.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Controllers
{
    public class CertificateBirthController
    {
        private IUnitOfWork _unitOfWork;
        public CertificateBirthController()
        {
            _unitOfWork = Program.GetUnitOfWork();
        }
        public IQueryable<CertificateBirth> GetById(int id)
        {
            return _unitOfWork.CertificateBirths.Filter(x => x.Id == id)
                .Include(x => x.Doctor)
                .Include(x => x.DoctorPost)
                .Include(x => x.MotherEducation)
                .Include(x => x.MotherEducation)
                .Include(x => x.MotherEmployment)
                .Include(x => x.MotherFamilyStatus)
                .Include(x => x.PlaceChildBirth)
                .Include(x => x.ProfessionAcceptBirth)
                .Include(x => x.RecipientDoctype)
                .Include(x => x.People)
                .Include(x => x.RecipientRelationship)
                .Include(x => x.AddressPlaceBirth)
                .Include(x => x.AddressPlaceLivingMother)
                .Include(x => x.Clinic)
                .Include(x => x.DirectorClinic);
        }
        public bool NumberInRange(string number)
        {
            var isValid = false;
            isValid = _unitOfWork.Blanks.Filter(x => x.Number == number).Any();

            return isValid;
        }
        public List<CertificateBirth> GetListCertificate(CertificatesSearchViewModel search, int certificateStatus)
        {
            var query = _unitOfWork.CertificateBirths.All().Include(x => x.Remarks).AsNoTracking();

            if (!string.IsNullOrEmpty(search.FirstName))
            {
                query = query.Where(x => x.MotherFirstname.ToUpper().Contains(search.FirstName.ToUpper()));
            }
            if (!string.IsNullOrEmpty(search.LastName))
            {
                query = query.Where(x => x.MotherLastName.ToUpper().Contains(search.LastName.ToUpper()));
            }
            if (!string.IsNullOrEmpty(search.MiddleName))
            {
                query = query.Where(x => x.MotherMiddlename.ToUpper().Contains(search.MiddleName.ToUpper()));
            }
            if (!string.IsNullOrEmpty(search.Number))
            {
                query = query.Where(x => x.Number.ToUpper().Contains(search.Number.ToUpper()));
            }
            if (search.CreateDateOn.HasValue)
            {
                query = query.Where(x => x.CreatedDate <= search.CreateDateOn.Value);
            }

            if (search.CreateDateWith.HasValue)
            {
                query = query.Where(x => x.CreatedDate >= DbFunctions.TruncateTime(search.CreateDateWith.Value));
            }
            if (search.IssueDateOn.HasValue)
            {
                query = query.Where(x => x.IssuanceDate <= search.IssueDateOn.Value);
            }

            if (search.IssueDateWith.HasValue)
            {
                query = query.Where(x => x.IssuanceDate >= DbFunctions.TruncateTime(search.IssueDateWith.Value));
            }
            if (search.StatusId != null)
            {
                query = query.Where(x => x.StatusId == search.StatusId);
            }
           
            if (certificateStatus == (int)ListCertificateType.Remark)
            {
                var ids = _unitOfWork.CertificateBirthRemarks.Filter(x => x.IsFixed == false).Select(x => x.CertificateId).ToList();
                query = query.Where(x => ids.Contains(x.Id));
            }
            if(CurrentUser.HasRoles(RoleApp.CheckingCertificateBirth,false))
            {
                query = query.Where(x =>x.StatusId ==(int)CertificateStatus.Expertise);
            }
            else if(CurrentUser.HasRoles(RoleApp.DoctorCertBirth,false))
            {
                query = query.Where(x => x.DoctorId == CurrentUser.Id && (x.StatusId == (int)CertificateStatus.Created|| x.StatusId == (int)CertificateStatus.Issued|| x.StatusId == (int)CertificateStatus.Print|| x.StatusId == (int)CertificateStatus.Return));
            }
           
            return query.ToList();
        }
        public void AddRemark(int idCert, string fieldName, string remarkText)
        {
            _unitOfWork.CertificateBirthRemarks.AddOrUpdate(new CertificateBirthRemark { CertificateId = idCert, UserId = CurrentUser.Id, CreatedDate = DateTime.Now, FieldName = fieldName, Note = remarkText,IsFixed = false });
            ChangeStatus(idCert, (int)CertificateStatus.Return);
            _unitOfWork.Commit();

        }
        public void ClearRemarks(int idCertificate)
        {
            var remarks = _unitOfWork.CertificateBirthRemarks.Filter(x => x.CertificateId == idCertificate).ToList();
            foreach (var item in remarks ?? Enumerable.Empty<CertificateBirthRemark>())
            {
                item.IsFixed = true;
            }
            _unitOfWork.Commit();
        }
        public List<CertificateBirthRemark> GetRemarks(int idCertificate)
        {
            return _unitOfWork.CertificateBirthRemarks.Filter(x => x.CertificateId == idCertificate && x.IsFixed == false).ToList();
        }
        public void ChangeStatus(int idCert, int statusId)
        {
            var cert = GetById(idCert).FirstOrDefault();
            Reload(cert);
            cert.StatusId = statusId;
            AddOrUpdate(cert);
        }
        public bool AddOrUpdate(CertificateBirth model)
        {
            try
            {
                _unitOfWork.CertificateBirths.AddOrUpdate(model);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool IsExistNumber(string number, int id)
        {
            return _unitOfWork.CertificateBirths.Filter(x => x.Number == number && x.Id != id).AsNoTracking().Any();
        }
        public void Reload(CertificateBirth certificate)
        {
            _unitOfWork.CertificateBirths.Reload(certificate);
        }
    }
}
