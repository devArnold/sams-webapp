using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAMS.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$",ErrorMessage ="First name should start with an upper case letter and contains no spaces")]
        [StringLength(30,ErrorMessage ="First name cannot be more than 30 characters")]
        public string FirstName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Last name should start with an upper case letter and contains no spaces")]
        [StringLength(30, ErrorMessage = "Last name cannot be more than 30 characters")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime EnrollmentDate { get; set; }


        public virtual ICollection<Enrollments> Enrollments { get; set; }


    }
}