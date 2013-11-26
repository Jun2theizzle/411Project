using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace FreeTime.Models
{
    public class Course
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public string Name { get; set; }
        public ICollection<Lecture> Lectures { get; set; }
        public ICollection<int> StudentIDs { get; set; }

        public Course()
        {
            Lectures = new Collection<Lecture>();
            StudentIDs = new Collection<int>();
        }
        public Course(int CRN, string CourseName)
        {
            CourseID = CRN;
            Name = CourseName;
            Lectures = new Collection<Lecture>();
            StudentIDs = new Collection<int>();

        }
    }
}

