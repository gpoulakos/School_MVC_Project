using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1.Entities
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required(), MaxLength(60), MinLength(2)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(), MaxLength(60), MinLength(2)]
        [Display(Name = "Stream")]
        public string Stream { get; set; }

        [Required(), MaxLength(60), MinLength(2)]
        [Display(Name = "Type")]
        public string Type { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        // --------- Navigation Properties

        public virtual Trainer Trainer { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
