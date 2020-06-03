using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment2._1.Entities
{
    public class StudentAssignment
    {
        [Key, Column(Order = 1)]
        public int StudentId { get; set; }
        [Key, Column(Order = 2)]

        public int AssignmentId { get; set; }
        [Range(0, 100)]
        public float CodeMark { get; set; }
        [Range(0, 100)]
        public double OralMark { get; set; }
        [Range(0, 100)]
        public double TotalMark { get; set; }

        public virtual Student Student { get; set; }
        public virtual Assignment Assignment { get; set; }
    }
}
