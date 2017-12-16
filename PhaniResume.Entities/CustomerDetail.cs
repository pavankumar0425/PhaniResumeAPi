using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaniResume.Entities
{
    public class CustomerDetail
    {
        public CustomerDetail()
        {
            ResumeDetails = new HashSet<ResumeDetail>();
        }

        public int CustomerDetailsID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string phoneNumber { get; set; }

        public string Zipcode { get; set; }

        public virtual ICollection<ResumeDetail> ResumeDetails { get; set; }
    }
}  
