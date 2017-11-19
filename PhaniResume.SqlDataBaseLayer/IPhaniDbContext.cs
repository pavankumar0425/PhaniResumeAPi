using System;
using System.Collections.Generic;
using System.Data.Entity;
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

    }
}