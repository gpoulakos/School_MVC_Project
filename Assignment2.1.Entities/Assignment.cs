using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1.Entities
{
    public class Assignment
    {
        public int AssignmentId { get; set; }


        [Required(), MaxLength(60), MinLength(2)]
        [Display(Name = "Title")]
        public string Title { get; set; }


        [Required(), MaxLength(60), MinLength(2)]
        [Display(Name = "Description of the assignment")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Submission Date")]
        public DateTime SubDateTime { get; set; }


        // --------- Navigation Properties
        public virtual Course Course { get; set; }
        public virtual ICollection<StudentAssignment> StudentAssignments { get; set; }
    }
}
