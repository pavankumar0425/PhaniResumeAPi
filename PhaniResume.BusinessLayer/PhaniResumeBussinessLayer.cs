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

        public List<ResumeDetail> GetAllResumeDetailsByCustomer()
        {
            var s = _phaniResumeDataLayer.GetAllResumeDetailsByCustomer().ToList();
            return _mapper.Map<List<Data_ResumeDetail>, List<ResumeDetail>>(s);
            
        }
    }
}
