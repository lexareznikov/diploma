using Demography.Domain.Classes;
using Demography.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demography.WinForms.Controllers
{
    public class NewsController
    {
       
        private IUnitOfWork _unitOfWork;
        public NewsController()
        {
            _unitOfWork = Program.GetUnitOfWork();
        }
        public List<News> GetNews()
        {
            return _unitOfWork.Newses.AsNoTracking().OrderByDescending(x=>x.Date).ToList();
        }

        public bool DeleteNews(int id)
        {
            try
            {
                _unitOfWork.Newses.Delete(id);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AddNews(News news)
        {
            try
            {
                _unitOfWork.Newses.AddOrUpdate(news);
               _unitOfWork.Commit();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public News GetById(int id)
        {
            return _unitOfWork.Newses.Filter(x => x.Id == id).FirstOrDefault();
        }
    }
}
