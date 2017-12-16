using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaniResume.SqlDataBaseLayer.Entities.resume.Configuration
{
   public  class CustomerDetailsConfiguration : EntityTypeConfiguration<Data_CustomerDetail>
    {
        public CustomerDetailsConfiguration()
        {
            ToTable("CustomerDetails");
            HasKey(x => x.CustomerDetailsID);
        }
    }
}
