using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMVC.Models
{
    public class UserProfile
    {
        public int ProfileId { set; get; }
        public string FullName { set; get; }
        public string Email { set; get; }
        public string Gender { set; get; }
        public string Birthday { set; get; }
        public string Password { private set; get; }
        public string Relationship { set; get; }
        public int ContactNumber { set; get; }
        public string UniversityName { set; get; }
        public string UniversityDegree { set; get; }
        public string CollegeName { set; get; }
        public string CollegeDegree { set; get; }
        public string SchoolName { set; get; }
        public string SchoolDegree { set; get; }
        public string Friends { get; set; }
    }
}