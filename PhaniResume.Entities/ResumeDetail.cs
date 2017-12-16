using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaniResume.Entities
{
   public class ResumeDetail
    {
        public int ResumeDetailsId { get; set; }

        public string CAREER_OBJECTIVE { get; set; }

        public string HONORS_AND_REWARDS { get; set; }

        public string PROFESSIONAL_RESPONSIBILITIES { get; set; }

        public string RELATED_EXPERIENCE { get; set; }

        public int? CustomerDetailsID { get; set; }

        public int? DisplayStyleId { get; set; }

        public virtual CustomerDetail CustomerDetail { get; set; }

        public virtual DisplayStyle DisplayStyle { get; set; }
    }
}
