using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMVC.Models
{
    public class UserPost
    {
        public int PostId { set; get; }
        public string PostName { set; get; }
        public UserProfile UserProfile { set; get; }
        public UserComment UserComment { set; get; }
    }
}