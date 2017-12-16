using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperExtensions;
using PhaniResume.BusinessLayer.Interfaces;
using PhaniResume.DataLayer.Interface;
using PhaniResume.Entities;
using PhaniResume.SqlDataBaseLayer.Entities.resume;

namespace PhaniResume.BusinessLayer
{
    public class PhaniResumeBussinessLayer :IPhaniResumeBussinessLayer
    {
        private readonly IPhaniResumeDataLayer _phaniResumeDataLayer;
        private readonly IMapper _mapper;


        public PhaniResumeBussinessLayer(IPhaniResumeDataLayer phaniResumeDataLayer, IMapper mapper)
        {
            _phaniResumeDataLayer = phaniResumeDataLayer;
            _mapper = mapper;
        }

        public List<ResumeDetail> GetAllResumeDetailsByCustomer(int customerId)
        {
            var s = _phaniResumeDataLayer.GetAllResumeDetailsByCustomer(customerId).ToList();
            return _mapper.Map<List<Data_ResumeDetail>, List<ResumeDetail>>(s);
            
        }

        public CustomerDetail GetcustomerByCustomer(int customerId)
        {
            var s = _phaniResumeDataLayer.GetcustomerByCustomer(customerId);
            return _mapper.Map<Data_CustomerDetail, CustomerDetail>(s);
        }

        public bool SaveResumeDetails(CustomerDetail customerDetail)
        {
            var result = _mapper.Map<CustomerDetail,Data_CustomerDetail>(customerDetail);
            return _phaniResumeDataLayer.SaveResumeDetails(result);
        }
    }
} 
