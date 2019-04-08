using SAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAMS.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {

        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
        {
            new Student{FirstName="John",LastName="Peter",EnrollmentDate= DateTime.Parse("2018-05-28")},
            new Student{FirstName="Mike",LastName="Mathew",EnrollmentDate= DateTime.Parse("2018-06-26")},
            new Student{FirstName="Paul",LastName="John",EnrollmentDate= DateTime.Parse("2018-04-08")},
            new Student{FirstName="Mary",LastName="Elizabeth",EnrollmentDate= DateTime.Parse("2018-09-17")}

        };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courseUnits = new List<CourseUnit>
            {
                new CourseUnit{Id=2010,Title="Object Oriented Programming",Credits=4},
                new CourseUnit{Id=2015,Title="Structured Programming",Credits=3},
                new CourseUnit{Id=2002,Title="Database Programming",Credits=4},
                new CourseUnit{Id=2108,Title="Data Structures and Algorithms",Credits=4},
                new CourseUnit{Id=2112,Title="Computer Architecture and Organisation",Credits=3},
                new CourseUnit{Id=2105,Title="Discrete Math",Credits=5},
                new CourseUnit{Id=2106,Title="Numerical Analysis",Credits=3},
                new CourseUnit{Id=2116,Title="Cryptography",Credits=4},
                new CourseUnit{Id=2119,Title="Artificial Intelligence",Credits=5},
            };

            courseUnits.ForEach(s => context.CourseUnits.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollments>
            {
                new Enrollments{CourseID=2010,StudentID=1,Grade=Grade.A},
                new Enrollments{CourseID=2116,StudentID=1,Grade=Grade.A},
                new Enrollments{CourseID=2119,StudentID=1,Grade=Grade.B},
                new Enrollments{CourseID=2108,StudentID=1,Grade=Grade.D},
                new Enrollments{CourseID=2010,StudentID=2,Grade=Grade.C},
                new Enrollments{CourseID=2015,StudentID=2},
                new Enrollments{CourseID=2002,StudentID=2,Grade=Grade.D},
                new Enrollments{CourseID=2015,StudentID=3,Grade=Grade.C},
                new Enrollments{CourseID=2112,StudentID=3,Grade=Grade.D},
                new Enrollments{CourseID=2108,StudentID=3},
                new Enrollments{CourseID=2105,StudentID=4,Grade=Grade.C},
                new Enrollments{CourseID=2106,StudentID=4,Grade=Grade.F},
                new Enrollments{CourseID=2116,StudentID=4,Grade=Grade.B},
                new Enrollments{CourseID=2119,StudentID=4,Grade=Grade.A},
            };

            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();


            //base.Seed(context);
        }

       
    }
}