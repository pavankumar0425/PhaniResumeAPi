using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhaniResume.SqlDataBaseLayer.Entities.resume;

namespace PhaniResume.SqlDataBaseLayer
{
    public interface IPhaniDbContext
    {
        DbSet<Data_CustomerDetail> CustomerDetails { get; set; }
        DbSet<Data_DisplayStyle> DisplayStyles { get; set; }
        DbSet<Data_ResumeDetail> ResumeDetails { get; set; }
        int Save();
        Task<int> SaveChangesAsync();
        Database Database { get; }

        DbEntityEntry Entity(object entity);

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}