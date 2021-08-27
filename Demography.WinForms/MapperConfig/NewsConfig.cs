using Demography.Domain.Classes;
using Demography.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.MapperConfig
{
    public class NewsConfig
    {
        public News NewsModelToNews(NewsViewModel model)
            {
            return new News { NewsFull = model.NewsFull, Date = model.Date, NewsShort = model.NameShort };
            }
        public News NewsModelToNews(NewsViewModel model, News News)
        {
            News.NewsFull = model.NewsFull;
            News.Date = model.Date;
            News.NewsShort = model.NameShort;
            return  News ;
        }
        public NewsViewModel NewsToNewsModel(News model)
        {
            return new NewsViewModel { NewsFull = model.NewsFull, Date = model.Date, NameShort = model.NewsShort };
        }
    }
}
