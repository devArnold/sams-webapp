using System.Data.Entity;
using SAMS.Models;

namespace SAMS.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
        }

        public DbSet<Student>Students { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }
        public DbSet<CourseUnit> CourseUnits { get; set; }
    

    }
}