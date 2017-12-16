using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaniResume.SqlDataBaseLayer.Entities.resume.Configuration
{
    public class ResumeDetailsConfiguration : EntityTypeConfiguration<Data_ResumeDetail>
    {
        public ResumeDetailsConfiguration()
        {
            ToTable("ResumeDetails");
            HasKey(x => x.ResumeDetailsId);
        }
    }
}
