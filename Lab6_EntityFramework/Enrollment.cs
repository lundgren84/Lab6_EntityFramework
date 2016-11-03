using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab6_EntityFramework
{
    public class Enrollment
    {
        [Key]
        public int EntrollmentID { get; set; }
        public string EnrollmentName { get; set; }
        public string Grade { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}