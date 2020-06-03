using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1.Entities
{
    public class Student
    {

        public int StudentId { get; set; }

        [Required(ErrorMessage = "Your name is required"), MaxLength(60), MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "This is not a valid name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Your surname is required"), MaxLength(60), MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "This is not a valid name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Currency)]
        [Range(2000, 10000, ErrorMessage = "Please input a valid price between 2000 and 10000")]
        [Display(Name = "Tuition Fees")]
        public int TuitionFees { get; set; }
        [NotMapped]
        public int Age
        {
            get { return DateTime.Now.Year - this.DateOfBirth.Year; }
        }


        // --------- Navigation Properties

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }

        public virtual ICollection<StudentAssignment> StudentAssignments { get; set; }

    }
}



