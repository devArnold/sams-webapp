using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAMS.Models
{

    public enum Grade
    {
        A, B, C, D, E, F
    }
    public class Enrollments
    {

        public int ID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public virtual CourseUnit CourseUnit { get; set; }
        public virtual Student Student { get; set; }



    }
}