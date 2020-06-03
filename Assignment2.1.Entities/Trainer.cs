using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1.Entities
{
    public class Trainer
    {
        public int TrainerId { get; set; }

        [Required(), MaxLength(60), MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "This is not a valid name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required(), MaxLength(60), MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "This is not a valid name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(), MaxLength(60), MinLength(2)]
        [Display(Name = "Field of expertise")]
        public string Subject { get; set; }


        // --------- Navigation Properties

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }

    }
}
