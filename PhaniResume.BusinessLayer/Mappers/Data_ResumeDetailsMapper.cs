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
            CreateMap<Data_ResumeDetail, ResumeDetail>().MaxDepth(1);
            CreateMap<Data_DisplayStyle, DisplayStyle>().MaxDepth(1);
            CreateMap<Data_CustomerDetail, CustomerDetail>().MaxDepth(1);
        }
    }
}
