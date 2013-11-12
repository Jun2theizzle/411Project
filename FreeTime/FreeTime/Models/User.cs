using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace FreeTime.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        ICollection<int> CourseIDs { get; set; }
        public enum UserType
        {
            Student, Prof
        };

        public User()
        {
            CourseIDs = new Collection<int>();
        }
    }
}
