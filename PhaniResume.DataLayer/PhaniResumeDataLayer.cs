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
using PhaniResume.SqlDataBaseLayer.Repository;

namespace PhaniResume.DataLayer
{
    public class PhaniResumeDataLayer :IPhaniResumeDataLayer
    {
        private readonly IPhaniDbContext _phaniDbContext;
        private readonly Repository<Data_CustomerDetail> _customerDetailsRepository;
        private readonly Repository<Data_ResumeDetail> _resumeDetailsRepository;

        public PhaniResumeDataLayer(IPhaniDbContext phaniDbContext, Repository<Data_CustomerDetail> customerDetailsRepository, Repository<Data_ResumeDetail> resumeDetailsRepository)
        {
            _phaniDbContext = phaniDbContext;
            _customerDetailsRepository = customerDetailsRepository;
            _resumeDetailsRepository = resumeDetailsRepository;
        }

        public List<Data_ResumeDetail> GetAllResumeDetailsByCustomer(int customerId)
        {
          return _phaniDbContext.ResumeDetails
                .Where(x=>x.CustomerDetailsID == customerId).ToList();
        }


        public Data_CustomerDetail GetcustomerByCustomer(int customerId)
        {
            //return _customerDetailsRepository.Query(x => x.CustomerDetailsID == customerId)
            //    .Include(x=>x.ResumeDetails.Select(y=>y.DisplayStyle))
            //    .First();

            return _phaniDbContext.CustomerDetails
                .Include(x => x.ResumeDetails)
                .FirstOrDefault(x => x.CustomerDetailsID == customerId);

        }

        public bool SaveResumeDetails(Data_CustomerDetail customerDetail)
        {
            var resumeId = customerDetail.ResumeDetails.First().ResumeDetailsId;
            var resumeDetails = _resumeDetailsRepository.Query(x => x.ResumeDetailsId == resumeId);
            if (resumeDetails.Any())
            {
                resumeDetails.Single().CAREER_OBJECTIVE = customerDetail.ResumeDetails.First().CAREER_OBJECTIVE;
                resumeDetails.Single().HONORS_AND_REWARDS = customerDetail.ResumeDetails.First().HONORS_AND_REWARDS;
                resumeDetails.Single().PROFESSIONAL_RESPONSIBILITIES = customerDetail.ResumeDetails.First().PROFESSIONAL_RESPONSIBILITIES;
                resumeDetails.Single().DisplayStyleId = customerDetail.ResumeDetails.First().DisplayStyleId;
                resumeDetails.Single().RELATED_EXPERIENCE = customerDetail.ResumeDetails.First().RELATED_EXPERIENCE;
                resumeDetails.Single().CustomerDetailsID = customerDetail.ResumeDetails.First().CustomerDetailsID;
            }
            else
            {
                var s = _phaniDbContext.ResumeDetails.Add(new Data_ResumeDetail()
                {
                    CAREER_OBJECTIVE = customerDetail.ResumeDetails.First().CAREER_OBJECTIVE,
                    HONORS_AND_REWARDS = customerDetail.ResumeDetails.First().HONORS_AND_REWARDS,
                    PROFESSIONAL_RESPONSIBILITIES = customerDetail.ResumeDetails.First().PROFESSIONAL_RESPONSIBILITIES,
                    DisplayStyleId = customerDetail.ResumeDetails.First().DisplayStyleId,
                    RELATED_EXPERIENCE = customerDetail.ResumeDetails.First().RELATED_EXPERIENCE,
                    CustomerDetailsID = customerDetail.ResumeDetails.First().CustomerDetailsID
            });
                _phaniDbContext.ResumeDetails.Add(s);
            }
            _phaniDbContext.Save();
            return true;
        }
    }
}
