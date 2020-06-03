using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1.Entities
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string Url { get; set; }


        // --------- Navigation Properties
        public virtual Trainer Trainer { get; set; }
        public virtual Student Student { get; set; }
    }
}
