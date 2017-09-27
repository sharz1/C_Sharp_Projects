using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsCourses
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public Dictionary<Course, Grade> Coursegrades { get; set; }
    }
}