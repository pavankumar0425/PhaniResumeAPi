using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
