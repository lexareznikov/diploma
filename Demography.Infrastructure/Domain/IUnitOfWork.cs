using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demography.Domain.Classes;
using Demography.Domain.Classes.Nsi;

namespace Demography.Infrastructure.Domain
{
    public interface IUnitOfWork
    {
        IRepository<CertificateBirth> CertificateBirths { get; }
       
        IRepository<Clinic> Clinics { get; }
        IRepository<Education> Educations { get; }
        IRepository<Employment> Employments { get; }
        IRepository<FamilyStatus> FamilyStatuses { get; }
        
        IRepository<ProfessionAcceptBirth> ProfessionAcceptBirths { get; }
      
        IRepository<User> Users { get; }
        IRepository<PlaceChildbirth> PlaceChildbirths { get; }
     
        IRepository<UserClinic> UserClinics { get; }
        
        IRepository<Role> Roles { get; }
        IRepository<Permission> Permissions { get; }
        IRepository<CertificateBirthRemark> CertificateBirthRemarks { get; }
     
        IRepository<PeopleDoc> PeopleDocs { get; }
        IRepository<People> Peoples { get; }
        IRepository<PeopleDocType> PeopleDocTypes { get; }
        IRepository<Address> Addresses { get; }
     
        IRepository<UserRole> UserRoles { get; }
    
        IRepository<Blank> Blanks { get; }
        IRepository<BlankIncome> BlankIncomes { get; }
       
       
        IRepository<News> Newses { get; }
       
        IRepository<Document> Documents { get; }
       
        IRepository<FamilyRelationship> FamilyRelationships { get; }
      
        IRepository<PositionFed00004> PositionFed00004s { get; }
       

        void Commit();
        Task<List<object>> SqlQuery(Type elementType, string sql, params object[] parameters);
        Task<int> CommitAsync();
        void SetLazyLoad(bool set);
    }
}