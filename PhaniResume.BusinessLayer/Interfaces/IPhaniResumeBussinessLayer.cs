﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhaniResume.Entities;

namespace PhaniResume.BusinessLayer.Interfaces
{
   public  interface IPhaniResumeBussinessLayer
   {
       List<ResumeDetail> GetAllResumeDetailsByCustomer(int customerId);
       CustomerDetail GetcustomerByCustomer(int customerId);
       bool SaveResumeDetails(CustomerDetail customerDetail);

   }
}
