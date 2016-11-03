using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-2
            // Just Printing
            //Console.WriteLine("1-2");
            //Console.WriteLine("Normal Print");
            //CRUD.PrintAllSudents();
            //Console.WriteLine(Environment.NewLine);


            // 3
            // Include
            //Console.WriteLine("3. print with include");
            //Console.WriteLine("Print with include");
            //List<Student> stud;
            //using (Lab6DBContext ctx = new Lab6DBContext())
            //{
            //    stud = ctx.Students.Include(x => x.Enrollments).ToList<Student>();
            //}
            //PrintAllStudents(stud);
            //Console.WriteLine(Environment.NewLine);


            // 4
            Console.WriteLine("4.");
            using (Lab6DBContext ctx = new Lab6DBContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;


                Console.WriteLine("enter name on student");
                string studentname = Console.ReadLine();
                var student = ctx.Students.Where(x => x.FirstMidName.StartsWith(studentname)).FirstOrDefault();

                Console.WriteLine(student.ToString());
                foreach (var item in student.Enrollments)
                {
                    Console.WriteLine($@"{item.EntrollmentID}  {item.EnrollmentName}  {item.Grade}");
                }
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("This is a  explicit loading!");

                (ctx.Entry(student).Collection(x => x.Enrollments)).Load();
                Console.WriteLine(student.ToString());
                foreach (var item in student.Enrollments)
                {
                    Console.WriteLine($@"{item.EntrollmentID}  {item.EnrollmentName}  {item.Grade}");
                }
            }

            Console.ReadKey();
        }


        public static void PrintAllStudents(List<Student> studentLista)
        {
            if (studentLista != null)
            {
                foreach (var item in studentLista)
                {
                    Console.WriteLine(item.ToString());

                    foreach (var enroll in item.Enrollments)
                    {
                        Console.WriteLine(enroll.EnrollmentName);
                    }
                }
            }
            else { Console.WriteLine("No students!"); }
        }
    }
}
