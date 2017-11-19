using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaniResume.Entities
{
    public class DisplayStyle
    {
        public DisplayStyle()
        {
            ResumeDetails = new HashSet<ResumeDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DisplayStyleID { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public virtual ICollection<ResumeDetail> ResumeDetails { get; set; }
    }
}
