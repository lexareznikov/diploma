using Demography.Domain.Classes;
using Demography.Infrastructure.Enums;
using Demography.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demography.WinForms.MapperConfig
{
    public class PeopleConfig
    {
        public People PeopleEditViewModelToPeople(PeopleEditViewModel model, People people = null)
        {
            if (people == null)
            {
                people = new People();
            }
            people.OmsEnp = model.OmsEnp;
            people.OmsNumber = model.OmsNumber;
            people.OmsSeries = model.OmsSeries;
            people.Job = model.WorkPlace;
            people.Post = model.Position;
            people.Snils = string.IsNullOrEmpty(model.Snils)?null:model.Snils;
            people.FirstName = model.FirstName;
            people.LastName = model.LastName;
            people.MiddleName = model.MiddleName;
            people.PlaceBirth = model.BirthPlace;
            people.Phone = model.Phone;
            people.BirthDate = model.BirthDate;
            people.SexId = (int)SexPeople.Female;
            if (!model.WithoutDoc)
            {
                if (people.Documents == null || people.Documents.Count==0)
                {
                    people.Documents = new List<PeopleDoc>();
                    people.Documents.Add(new PeopleDoc()
                    {
                        DoctypeId = model.DocTypeId.Value,
                        Series = model.DocSeries,
                        Number = model.DocNumber,
                        ExpirationDateTime = model.DocDateOn,
                        IssueDateTime = model.DocDateWith,
                        Issuer = model.DocOrgName
                    });
                }
                else
                {
                    var doc = people.Documents.FirstOrDefault();
                    doc.DoctypeId = model.DocTypeId.Value;
                    doc.Series = model.DocSeries;
                    doc.Number = model.DocNumber;
                    doc.ExpirationDateTime = model.DocDateOn;
                    doc.IssueDateTime = model.DocDateWith;
                    doc.Issuer = model.DocOrgName;
                }
            }
            else
            {
                people.Documents = null;
            }
            if (!model.IsForeigner && !model.IsHomeless )
            {
                if (people.PlaceLiving == null)
                {
                    people.PlaceLiving = new Address
                    {
                        Country = model.Country,
                        Locality = model.Locality,
                        District = model.District,
                        Region = model.Region,
                        Street = model.Street,
                        House = model.House,
                        Flat = model.Flat,
                        Housing = model.Housing,
                        Room = model.Room,
                        Build = model.Build,
                        Location = model.Location
                    };
                }
                else
                {
                    people.PlaceLiving.Country = model.Country;
                    people.PlaceLiving.Locality = model.Locality;
                    people.PlaceLiving.District = model.District;
                    people.PlaceLiving.Region = model.Region;
                    people.PlaceLiving.Street = model.Street;
                    people.PlaceLiving.House = model.House;
                    people.PlaceLiving.Flat = model.Flat;
                    people.PlaceLiving.Housing = model.Housing;
                    people.PlaceLiving.Room = model.Room;
                    people.PlaceLiving.Build = model.Build;
                    people.PlaceLiving.Location = model.Location;
                }
            }
            else
            {
                people.PlaceLiving = null;
                people.PlaceLivingId = null;
            }
            people.IsForeigner = model.IsForeigner;
            people.IsHomeless = model.IsHomeless;
            people.Id = model.PeopleId;


            return people;
        }


        public PeopleEditViewModel PeopleToPeopleEditViewModel(People people)
        {
            var model = new PeopleEditViewModel();
            model.OmsEnp = people.OmsEnp;
            model.OmsNumber = people.OmsNumber;
            model.OmsSeries = people.OmsSeries;
            model.WorkPlace = people.Job;
            model.Position = people.Post;
            model.Snils = people.Snils;
            model.FirstName = people.FirstName;
            model.LastName = people.LastName;
            model.MiddleName = people.MiddleName;
            model.BirthPlace = people.PlaceBirth;
            model.Phone = people.Phone;
            model.BirthDate = people.BirthDate;
            model.SexId = people.SexId;
            if (people.Documents != null && people.Documents.Count>0)
            {
                var document = people.Documents.OrderByDescending(x => x.Id).FirstOrDefault();
                model.DocTypeId = document.DoctypeId;
                model.DocSeries = document.Series;
                model.DocNumber = document.Number;
                model.DocDateOn = document.ExpirationDateTime;
                model.DocDateWith = document.IssueDateTime;
                model.DocOrgName = document.Issuer;
            }
            else
            {
                model.WithoutDoc = true;
            }
            if (people.PlaceLiving != null)
            {
                model.Country = people.PlaceLiving.Country;
                model.Locality = people.PlaceLiving.Locality;
                model.District = people.PlaceLiving.District;
                model.Region = people.PlaceLiving.Region;
                model.Street = people.PlaceLiving.Street;
                model.House = people.PlaceLiving.House;
                model.Flat = people.PlaceLiving.Flat;
                model.Housing = people.PlaceLiving.Housing;
                model.Room = people.PlaceLiving.Room;
                model.Build = people.PlaceLiving.Build;
                model.Location = people.PlaceLiving.Location;
            }
            model.IsForeigner = people.IsForeigner;
            model.IsHomeless = people.IsHomeless;
            model.PeopleId = people.Id;


            return model;
        }

    }
}
