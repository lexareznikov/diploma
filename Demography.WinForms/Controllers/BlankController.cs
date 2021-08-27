using Demography.Domain.Classes;
using Demography.Infrastructure.Domain;
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
    public class BlankController
    {
        private IUnitOfWork _unitOfWork;
        public BlankController()
        {
            _unitOfWork = Program.GetUnitOfWork();
        }
        public bool AddIncome (AddBlankViewModel model)
        {
            try
            {
                var vlancIncome = new Domain.Classes.BlankIncome
                {
                    Series = model.Series,
                    Count = model.Count,
                    CreateDate = model.IncomeDate,
                    NumberFirst = model.NumberFirst,
                    UserId = CurrentUser.Id
                };
                _unitOfWork.BlankIncomes.AddOrUpdate(vlancIncome);
              
                int startNumber = int.Parse(model.NumberFirst);
                for(var t = 0; t<model.Count;t++)
                {
                    _unitOfWork.Blanks.AddOrUpdate(new Blank { CreatedDate = DateTime.Now, IncomeId = vlancIncome.Id, IsUsed = false, Number = startNumber.ToString(), Series = model.Series });
                    startNumber++;
                }
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public IQueryable<BlankIncome> GetListIncomes(BlankSearchViewModel search)
        {
            var query= _unitOfWork.BlankIncomes.All().Include(x => x.User);
            if (search.DateWith.HasValue)
            {
                query = query.Where(x => x.CreateDate >= DbFunctions.TruncateTime(search.DateWith.Value));
            }
            if (search.DateOn.HasValue)
            {
                query = query.Where(x => x.CreateDate <= search.DateOn.Value);
            }
            return query;
        }
        public int GetCount()
        {
            return _unitOfWork.Blanks.Count;
        }
        public IQueryable<CertificateBirth> GetListBirth()
        {
            return _unitOfWork.CertificateBirths.All();
        }
        public bool BeforeLastNumber (string number)
        {
            var isValid = false;

            var lastNumber = _unitOfWork.Blanks.All().OrderByDescending(x => x.Number).Select(x => x.Number).FirstOrDefault();
            isValid = String.Compare(lastNumber, number) >= 0;
            return isValid;
        }
    }
}
