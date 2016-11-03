using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_EntityFramework
{
   public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public Student()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }


        public override string ToString()
        {
            //List<string> enrollments = CRUD.GetENrollmentNames(this.StudentID);
      
            string student = $@"{this.StudentID} : {this.LastName}, {this.FirstMidName} {Environment.NewLine}   -Enrollments:";
           // enrollments.ForEach(x=> student += $@"      - {x} {Environment.NewLine}");        
            return student;
        }
    }
}
