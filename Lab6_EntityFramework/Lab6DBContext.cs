using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_EntityFramework
{
    class Lab6DBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Entrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
