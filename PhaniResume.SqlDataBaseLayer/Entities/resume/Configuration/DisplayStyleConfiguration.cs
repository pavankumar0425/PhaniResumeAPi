using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaniResume.SqlDataBaseLayer.Entities.resume.Configuration
{
    public class DisplayStyleConfiguration: EntityTypeConfiguration<Data_DisplayStyle>
    {
        public DisplayStyleConfiguration()
        {
            ToTable("DisplayStyle");
            HasKey(x => x.DisplayStyleID);
        }
    }
}
