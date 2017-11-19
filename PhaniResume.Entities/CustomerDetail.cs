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

        [Key]
        public int CustomerDetailsID { get; set; }

        [StringLength(500)]
        public string FirstName { get; set; }

        [StringLength(500)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string phoneNumber { get; set; }

        [StringLength(50)]
        public string Zipcode { get; set; }

        public virtual ICollection<ResumeDetail> ResumeDetails { get; set; }
    }
}  
