using Demography.BusinessLayer.Domain;
using Demography.Infrastructure.Domain;
using Demography.WinForms.Views.Authorization;
//using Devart.Data.PostgreSql;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demography.WinForms
{
    static class Program
    {
       static private IUnitOfWork unitOfWork;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
        static public IUnitOfWork GetUnitOfWork()
        {
            return unitOfWork == null ?unitOfWork = new UnitOfWork(new Domain.EFDbContext(new NpgsqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))) : unitOfWork;        }
    }
}
