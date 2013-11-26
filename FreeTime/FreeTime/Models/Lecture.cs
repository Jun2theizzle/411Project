using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FreeTime.Models
{
    public class Lecture
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Comment> Discussion { get; set; }
        public ICollection<int> StudentIDs { get; set; }

        [ForeignKey("CourseID")]
        public int CourseID { get; set; }

        public DateTime Date { get; set; }

        public Lecture()
        {
            Discussion = new Collection<Comment>();
            StudentIDs = new Collection<int>();
        }

        public Lecture(string _Name, int _CourseID, DateTime? _Date= null)
        {
            if (!_Date.HasValue)
                Date = DateTime.Now;
            else if (_Date.HasValue)
                Date = _Date.Value;
           
            Name = _Name;
            CourseID = _CourseID;
        }
    }
}

