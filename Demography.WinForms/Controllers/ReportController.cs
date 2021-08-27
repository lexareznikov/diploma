using AutoMapper;
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
    public class ReportController
    {
        private IUnitOfWork _unitOfWork;
        public ReportController()
        {
            _unitOfWork = Program.GetUnitOfWork();
        }

        public ReportViewModel GetReport()
        {

            var listCertificate = _unitOfWork.CertificateBirths.All().Include(x => x.People).ToList();
            var report = new ReportViewModel
            {
                AllMother = listCertificate.Select(x => x.PeopleId).Distinct().Count().ToString(),
                AllBoys = listCertificate.Where(x => x.SexId == (int)SexChild.Male).Select(x => x.Id).Distinct().Count().ToString(),
                AllGirls = listCertificate.Where(x => x.SexId == (int)SexChild.Female).Select(x => x.Id).Distinct().Count().ToString(),

                Before16Mother = listCertificate.Where(x => Age(x.People.BirthDate)<=16).Select(x => x.PeopleId).Distinct().Count().ToString(),
                Before16Boys = listCertificate.Where(x => x.SexId == (int)SexChild.Male && Age(x.People.BirthDate) <= 16).Select(x => x.Id).Distinct().Count().ToString(),
                Before16Girls = listCertificate.Where(x => x.SexId == (int)SexChild.Female && Age(x.People.BirthDate) <= 16).Select(x => x.Id).Distinct().Count().ToString(),

                Between1720Mother = listCertificate.Where(x => Age(x.People.BirthDate)>=17 && Age(x.People.BirthDate) <= 20).Select(x => x.PeopleId).Distinct().Count().ToString(),
                Between1720Boys = listCertificate.Where(x => x.SexId == (int)SexChild.Male && Age(x.People.BirthDate) >= 17 && Age(x.People.BirthDate) <= 20).Select(x => x.Id).Distinct().Count().ToString(),
                Between1720Girls = listCertificate.Where(x => x.SexId == (int)SexChild.Female && Age(x.People.BirthDate) >= 17 && Age(x.People.BirthDate) <= 20).Select(x => x.Id).Distinct().Count().ToString(),

                Between2125Mother = listCertificate.Where(x => Age(x.People.BirthDate) >= 21 && Age(x.People.BirthDate) <= 25).Select(x => x.PeopleId).Distinct().Count().ToString(),
                Between2125Boys = listCertificate.Where(x => x.SexId == (int)SexChild.Male && Age(x.People.BirthDate) >= 21 && Age(x.People.BirthDate) <= 25).Select(x => x.Id).Distinct().Count().ToString(),
                Between2125Girls = listCertificate.Where(x => x.SexId == (int)SexChild.Female && Age(x.People.BirthDate) >= 21 && Age(x.People.BirthDate) <= 25).Select(x => x.Id).Distinct().Count().ToString(),

                Between2635Mother = listCertificate.Where(x => Age(x.People.BirthDate) >= 26 && Age(x.People.BirthDate) <= 35).Select(x => x.PeopleId).Distinct().Count().ToString(),
                Between2635Boys = listCertificate.Where(x => x.SexId == (int)SexChild.Male && Age(x.People.BirthDate) >= 26 && Age(x.People.BirthDate) <= 35).Select(x => x.Id).Distinct().Count().ToString(),
                Between2635Girls = listCertificate.Where(x => x.SexId == (int)SexChild.Female && Age(x.People.BirthDate) >= 26 && Age(x.People.BirthDate) <= 35).Select(x => x.Id).Distinct().Count().ToString(),

                Between3645Mother = listCertificate.Where(x => Age(x.People.BirthDate) >= 36 && Age(x.People.BirthDate) <= 45).Select(x => x.PeopleId).Distinct().Count().ToString(),
                Between3645Boys = listCertificate.Where(x => x.SexId == (int)SexChild.Male && Age(x.People.BirthDate) >= 36 && Age(x.People.BirthDate) <= 45).Select(x => x.Id).Distinct().Count().ToString(),
                Between3645Girls = listCertificate.Where(x => x.SexId == (int)SexChild.Female && Age(x.People.BirthDate) >= 36 && Age(x.People.BirthDate) <= 45).Select(x => x.Id).Distinct().Count().ToString(),

                After45Mother = listCertificate.Where(x => Age(x.People.BirthDate) >= 46 ).Select(x => x.PeopleId).Distinct().Count().ToString(),
                After45Boys = listCertificate.Where(x => x.SexId == (int)SexChild.Male && Age(x.People.BirthDate) >= 46 ).Select(x => x.Id).Distinct().Count().ToString(),
                After45Girls = listCertificate.Where(x => x.SexId == (int)SexChild.Female && Age(x.People.BirthDate) >= 46).Select(x => x.Id).Distinct().Count().ToString()

            };
            return report;
        }


        private int Age(DateTime? BirthDate)
        {

            var now = DateTime.Now;
            var birthDate = BirthDate;


            var age = now.Year - birthDate.Value.Year;
            if (birthDate > now.AddYears(-age))
                age--;

            return age;




        }
    }
}
