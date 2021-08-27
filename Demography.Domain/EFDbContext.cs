using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Demography.Domain.Classes;
using Demography.Domain.Classes.Nsi;
using Demography.Domain.DAL;
using System.Data.Common;

namespace Demography.Domain
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbConnection conn) : base(conn, true)
        {
            (this as IObjectContextAdapter).ObjectContext.ContextOptions.UseCSharpNullComparisonBehavior = true;
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            Database.SetInitializer<EFDbContext>(null);
        }

       
       
        public virtual DbSet<CertificateBirth> CertificateBirths { get; set; }
        public virtual DbSet<Clinic> Clinics { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Employment> Employments { get; set; }
        public virtual DbSet<FamilyStatus> FamilyStatuses { get; set; }
        public virtual DbSet<ProfessionAcceptBirth> ProfessionAcceptBirths { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<PlaceChildbirth> PlaceChildbirths { get; set; }
        public virtual DbSet<UserClinic> UserClinics { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<CertificateBirthRemark> CertificateBirthRemarks { get; set; }
        public virtual DbSet<PeopleDoc> PeopleDocs { get; set; }
        public virtual DbSet<People> Peoples { get; set; }
        public virtual DbSet<PeopleDocType> PeopleDocTypes { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Blank> Blanks { get; set; }
        public virtual DbSet<BlankIncome> BlankIncomes { get; set; }
        public virtual DbSet<News> Newses { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<FamilyRelationship> FamilyRelationships { get; set; }
        public virtual DbSet<PositionFed00004> PositionFed00004 { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dem");
            modelBuilder.Configurations.Add(new UserClinicConfiguration());
            modelBuilder.Configurations.Add(new CertificateBirthConfiguration());
            modelBuilder.Entity<User>()
                        .HasMany(x => x.IndividualPermissions)
                        .WithMany(x => x.Users)
                        .Map(x =>
                        {
                            x.ToTable("user_permission", "main");
                            x.MapLeftKey("user_id");
                            x.MapRightKey("permission_id");
                        });


            modelBuilder.Entity<Permission>()
                      .HasMany(x => x.Roles)
                      .WithMany(x => x.Permissions)
                      .Map(x =>
                      {
                          x.ToTable("role_permission", "main");
                          x.MapLeftKey("permission_id");
                          x.MapRightKey("role_id");
                      });

            base.OnModelCreating(modelBuilder);
        }

    }
}
