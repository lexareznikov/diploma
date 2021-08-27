using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using Demography.Domain;
using Demography.Domain.Classes;

using Demography.Domain.Classes.Nsi;
using Demography.Infrastructure.Domain;


namespace Demography.BusinessLayer.Domain
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        
        private IRepository<CertificateBirth> _certificateBirths;
        private IRepository<Clinic> _clinics;
        private IRepository<Education> _educations;
        private IRepository<Employment> _employments;
        private IRepository<FamilyStatus> _familyStatuses;
        private IRepository<ProfessionAcceptBirth> _professionAcceptBirths;
        private IRepository<User> _users;
        private IRepository<PlaceChildbirth> _placeChildbirths;
        private IRepository<UserClinic> _userClinics;
        private IRepository<Role> _roles;
        private IRepository<Permission> _permissions;
        private IRepository<CertificateBirthRemark> _certificateBirthRemarks;
        private IRepository<PeopleDoc> _peopleDocs;
        private IRepository<People> _people;
        private IRepository<PeopleDocType> _peopleDocType;
        private IRepository<Address> _addresses;
        private IRepository<UserRole> _userRoles;
        private IRepository<Blank> _blanks;
        private IRepository<BlankIncome> _blankIncomes;
        private IRepository<News> _newses;
        private IRepository<Document> _documents;
        private IRepository<FamilyRelationship> _familyRelationship;
        private IRepository<PositionFed00004> _positionFed00004;

        public UnitOfWork(EFDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       

      

        public IRepository<User> Users => _users ?? (_users = new Repository<User>(_dbContext));
        public IRepository<PlaceChildbirth> PlaceChildbirths => _placeChildbirths ?? (_placeChildbirths = new Repository<PlaceChildbirth>(_dbContext));
        public IRepository<UserClinic> UserClinics => _userClinics ?? (_userClinics = new Repository<UserClinic>(_dbContext));
        public IRepository<Role> Roles => _roles ?? (_roles = new Repository<Role>(_dbContext));

        public IRepository<Permission> Permissions => _permissions ?? (_permissions = new Repository<Permission>(_dbContext));

        public IRepository<CertificateBirthRemark> CertificateBirthRemarks => _certificateBirthRemarks ?? (_certificateBirthRemarks = new Repository<CertificateBirthRemark>(_dbContext));

     
        public IRepository<PeopleDoc> PeopleDocs => _peopleDocs ?? (_peopleDocs = new Repository<PeopleDoc>(_dbContext));

        public IRepository<People> Peoples => _people ?? (_people = new Repository<People>(_dbContext));

        public IRepository<PeopleDocType> PeopleDocTypes => _peopleDocType ?? (_peopleDocType = new Repository<PeopleDocType>(_dbContext));

        public IRepository<Address> Addresses => _addresses ?? (_addresses = new Repository<Address>(_dbContext));
        public IRepository<UserRole> UserRoles => _userRoles ?? (_userRoles = new Repository<UserRole>(_dbContext));
        public IRepository<CertificateBirth> CertificateBirths => _certificateBirths ?? (_certificateBirths = new Repository<CertificateBirth>(_dbContext));

        public IRepository<Clinic> Clinics => _clinics ?? (_clinics = new Repository<Clinic>(_dbContext));
        public IRepository<Education> Educations => _educations ?? (_educations = new Repository<Education>(_dbContext));

        public IRepository<Employment> Employments => _employments ?? (_employments = new Repository<Employment>(_dbContext));

        public IRepository<FamilyStatus> FamilyStatuses => _familyStatuses ?? (_familyStatuses = new Repository<FamilyStatus>(_dbContext));
        public IRepository<ProfessionAcceptBirth> ProfessionAcceptBirths => _professionAcceptBirths ?? (_professionAcceptBirths = new Repository<ProfessionAcceptBirth>(_dbContext));
        
        public IRepository<Blank> Blanks => _blanks ?? (_blanks = new Repository<Blank>(_dbContext));

        public IRepository<BlankIncome> BlankIncomes => _blankIncomes ?? (_blankIncomes = new Repository<BlankIncome>(_dbContext));
        public IRepository<News> Newses => _newses ?? (_newses = new Repository<News>(_dbContext));
     
        public IRepository<Document> Documents => _documents ?? (_documents = new Repository<Document>(_dbContext));
        public IRepository<FamilyRelationship> FamilyRelationships => _familyRelationship ?? (_familyRelationship = new Repository<FamilyRelationship>(_dbContext));
        public IRepository<PositionFed00004> PositionFed00004s => _positionFed00004 ?? (_positionFed00004 = new Repository<PositionFed00004>(_dbContext));
       
        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public Task<List<object>> SqlQuery(Type elementType, string sql, params object[] parameters)
        {
            if (parameters.Length == 0)
                return _dbContext.Database.SqlQuery(elementType, sql).ToListAsync();
            return _dbContext.Database.SqlQuery(elementType, sql, parameters).ToListAsync();
        }

        public Task<int> CommitAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
        public void SetLazyLoad(bool set)
        {
            _dbContext.Configuration.LazyLoadingEnabled = set;
        }
    }
}