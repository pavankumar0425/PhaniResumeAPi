using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaniResume.SqlDataBaseLayer.Entities.resume
{
    public class Data_ResumeDetail
    {
        public int ResumeDetailsId { get; set; }

        [Column("CAREER OBJECTIVE")]
        [StringLength(4000)]
        public string CAREER_OBJECTIVE { get; set; }

        [Column("HONORS AND REWARDS")]
        [StringLength(4000)]
        public string HONORS_AND_REWARDS { get; set; }

        [Column("PROFESSIONAL RESPONSIBILITIES")]
        [StringLength(4000)]
        public string PROFESSIONAL_RESPONSIBILITIES { get; set; }

        [Column("RELATED EXPERIENCE")]
        [StringLength(4000)]
        public string RELATED_EXPERIENCE { get; set; }

        public int? CustomerDetailsID { get; set; }

        public int? DisplayStyleId { get; set; }

        public virtual Data_CustomerDetail CustomerDetail { get; set; }

        public virtual Data_DisplayStyle DisplayStyle { get; set; }
    }
}
