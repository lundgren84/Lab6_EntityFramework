using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_EntityFramework
{
   public class Course
    {
        [Key]
        public int CourseID{ get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
