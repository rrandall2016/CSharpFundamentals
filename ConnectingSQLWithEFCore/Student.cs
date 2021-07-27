using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingToSQLWithEFCore
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }


    }
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
