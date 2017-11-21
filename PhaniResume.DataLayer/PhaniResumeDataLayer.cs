using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PhaniResume.DataLayer.Interface;
using PhaniResume.SqlDataBaseLayer;
using PhaniResume.SqlDataBaseLayer.Entities.resume;

namespace PhaniResume.DataLayer
{
    public class PhaniResumeDataLayer :IPhaniResumeDataLayer
    {
        private readonly IPhaniDbContext _phaniDbContext;

        public PhaniResumeDataLayer(IPhaniDbContext phaniDbContext)
        {
            _phaniDbContext = phaniDbContext;
        }

        public List<Data_ResumeDetail> GetAllResumeDetailsByCustomer()
        {
          return _phaniDbContext.ResumeDetails.ToList();
        }


        public Data_CustomerDetail GetcustomerByCustomer(int customerId)
        {
            return _phaniDbContext.CustomerDetails
                .Include(x => x.ResumeDetails)
                .Include(x=>x.ResumeDetails.Select(y=>y.DisplayStyle))
                .First(x=>x.CustomerDetailsID == customerId);

        }
    }
}
