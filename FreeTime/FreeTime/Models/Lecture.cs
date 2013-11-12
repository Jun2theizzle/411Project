﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public int CourseID { get; set; }

        public Lecture()
        {
            Discussion = new Collection<Comment>();
            StudentIDs = new Collection<int>();
        }
    }
}

