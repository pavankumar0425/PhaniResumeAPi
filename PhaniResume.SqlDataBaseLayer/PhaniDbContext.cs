using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PhaniResume.SqlDataBaseLayer.Entities.resume;

namespace PhaniResume.SqlDataBaseLayer
{
    public class PhaniDbContext :DbContext , IPhaniDbContext
    {
        public PhaniDbContext() : base(ConnectionString())
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
        }

        private static string ConnectionString()
        {
            return ConfigurationManager.AppSettings[Constants.Appsetting_PhaniDbConnectionString];
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(GetType()));

            //modelBuilder.Entity<Data_ResumeDetail>()
            //    .HasRequired(c => ResumeDetails)
            //    .WithMany()
            //    .HasForeignKey(u => u.CustomerDetailsID);

            //modelBuilder.Entity<Data_ResumeDetail>()
            //    .HasRequired(c => c.DisplayStyle)
            //    .WithMany()
            //    .HasForeignKey(u => u.CustomerDetailsID);

            //modelBuilder.Entity<Data_ResumeDetail>()
            //    .HasOptional<Data_DisplayStyle>(s => s.DisplayStyle)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Data_ResumeDetail>()
            //    .HasOptional<Data_CustomerDetail>(s => s.CustomerDetail)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<Data_CustomerDetail>()
                .HasMany(x => x.ResumeDetails)
                .WithRequired(e => e.CustomerDetail)
                .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<Data_DisplayStyle>()
                .HasMany(x => x.ResumeDetails)
                .WithRequired(e => e.DisplayStyle)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Data_CustomerDetail>()
            //    .HasMany(x => x.ResumeDetails).WithRequired(e => e.CustomerDetail).WillCascadeOnDelete(false);

            ////modelBuilder.Entity<Data_CustomerDetail>()
            ////    .Map(x => x.Requires("ResumeDetails")).Ignore(e => e.ResumeDetails)
            ////    .Map(x => x.Requires("DisplayStyle")).Ignore(e => e.ResumeDetails);

            //modelBuilder.Entity<Data_DisplayStyle>()
            //    .HasMany(x => x.ResumeDetails).WithRequired(e => e.DisplayStyle).WillCascadeOnDelete(false);

        }

        public int Save()
        {
         return  base.SaveChanges();
        }

        public DbEntityEntry Entity(object entity)
        {
            throw new NotImplementedException();
        }
        //TODO: No-Urget-Over ride Save just to know. and all other possible overrides.

        public virtual DbSet<Data_CustomerDetail> CustomerDetails { get; set; }
        public virtual DbSet<Data_DisplayStyle> DisplayStyles { get; set; }
        public virtual DbSet<Data_ResumeDetail> ResumeDetails { get; set; }
    }
}
