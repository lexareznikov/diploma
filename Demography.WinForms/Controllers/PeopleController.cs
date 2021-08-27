using Demography.Domain.Classes;
using Demography.Infrastructure.Domain;
using Demography.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.Controllers
{
    public class PeopleController
    {
        private IUnitOfWork _unitOfWork;
        public PeopleController()
        {
            _unitOfWork = Program.GetUnitOfWork();
        }

        public IQueryable<People> GetById(int id)
        {
            return _unitOfWork.Peoples.Filter(x => x.Id == id).Include(x => x.PlaceLiving).Include(x=>x.Documents);
        }
        public void Reload(People people)
        {
            _unitOfWork.Peoples.Reload(people);
        }
        public bool AddOrUpdatePeople(People people)
        {
            try
            {
                _unitOfWork.Peoples.AddOrUpdate(people);
                _unitOfWork.Commit();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }
        public List<People> GetListPeople (PeopleSearchViewModel search)
        {
            var query = _unitOfWork.Peoples.All().Include(x => x.PlaceLiving).Include(x => x.Documents).AsNoTracking();
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
            //if (!string.IsNullOrEmpty(search.NumberPolicy))
            //{
            //    query = query.Where(x => x.Snils == search.NumberPolicy);
            //}
            var items = query.ToList();
            if (search.BirthDate != null)
            {
                items = items.Where(x =>
                    x.BirthDate != null && search.BirthDate != null &&
                    x.BirthDate.Value.Date == search.BirthDate.Value.Date).ToList();
            }
            return items;
        }
        public bool DeleteDoc(int id)
        {
            try
            {
                var people = GetById(id).FirstOrDefault();
                Reload(people);
                _unitOfWork.PeopleDocs.Delete(people.Documents.FirstOrDefault().Id);
                _unitOfWork.Commit();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool DeleteAddress(int id)
        {
            try
            {
                var people = GetById(id).FirstOrDefault();
                Reload(people);
                _unitOfWork.Addresses.Delete(people.PlaceLivingId);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
