using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeTime.Models
{
    public class Course
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public string Name { get; set; }

        public Course() { }
        public Course(int CRN, string CourseName)
        {
            CourseID = CRN;
            Name = CourseName;

        }
    }
}