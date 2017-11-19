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
        }

        private static string ConnectionString()
        {
            return ConfigurationManager.AppSettings[Constants.Appsetting_PhaniDbConnectionString];
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(GetType()));

        }
        //ToDO: No-Urget-Over ride Save just to know. and all other possible overrides.

        public virtual DbSet<Data_CustomerDetail> CustomerDetails { get; set; }
        public virtual DbSet<Data_DisplayStyle> DisplayStyles { get; set; }
        public virtual DbSet<Data_ResumeDetail> ResumeDetails { get; set; }
    }
}
