using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PhaniResume.Entities;
using PhaniResume.SqlDataBaseLayer.Entities.resume;

namespace PhaniResume.BusinessLayer.Mappers
{
    public class Data_ResumeDetailsMapper : Profile
    {
        public Data_ResumeDetailsMapper()
        {
            CreateMap<Data_ResumeDetail, ResumeDetail>().PreserveReferences();
            CreateMap<Data_DisplayStyle, DisplayStyle>().PreserveReferences();
            CreateMap<Data_CustomerDetail, CustomerDetail>().PreserveReferences();
        }
    }
}
