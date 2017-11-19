using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaniResume.SqlDataBaseLayer.Entities.resume
{
    [Table("CustomerDetails")]
    public class Data_CustomerDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Data_CustomerDetail()
        {
            ResumeDetails = new HashSet<Data_ResumeDetail>();
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Data_ResumeDetail> ResumeDetails { get; set; }
    }
}
