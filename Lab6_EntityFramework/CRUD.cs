using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_EntityFramework
{
    class CRUD
    {
        internal static List<string> GetENrollmentNames(int studentID)
        {
            using (Lab6DBContext ctx = new Lab6DBContext())
            {
                var result = ctx.Entrollments.Select(x=> x.EnrollmentName).ToList();
                return result;
            }
        }

        internal static void AddNewStudent(Student s)
        {
            using (Lab6DBContext ctx = new Lab6DBContext())
            {
                ctx.Students.Add(s);
                ctx.SaveChanges();
            }
        }
        internal static void AddNewEnrollment(Enrollment e)
        {
            using (Lab6DBContext ctx = new Lab6DBContext())
            {
                ctx.Entrollments.Add(e);
                ctx.SaveChanges();
            }
        }
        internal static void AddNewCourse(Course e)
        {
            using (Lab6DBContext ctx = new Lab6DBContext())
            {
                ctx.Courses.Add(e);
                ctx.SaveChanges();
            }
        }
        internal static void PrintAllSudents()
        {
            using (Lab6DBContext ctx = new Lab6DBContext())
            {             
                var students = ctx.Students.ToList();              
               
                foreach (var item in students)
                {
                    Console.WriteLine(item.ToString());

                    foreach (var enroll in item.Enrollments)
                    {
                        Console.WriteLine($@"      - {enroll.EnrollmentName}");
                    }
                    Console.WriteLine(Environment.NewLine);
                }
            }
        }
        internal static void RedoDataBase()
        {
            using (Lab6DBContext ctx = new Lab6DBContext())
            {
                ctx.Database.Delete();
                ctx.Database.CreateIfNotExists();
            }
        }
    }
}
