using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhaniResume.SqlDataBaseLayer.Entities.resume;

namespace PhaniResume.DataLayer.Interface
{
    public interface IPhaniResumeDataLayer
    {
        List<Data_ResumeDetail> GetAllResumeDetailsByCustomer(int customerId);
        Data_CustomerDetail GetcustomerByCustomer(int customerId);
        bool SaveResumeDetails(Data_CustomerDetail customerDetail);
    }
}
