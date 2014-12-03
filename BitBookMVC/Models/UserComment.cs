using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMVC.Models
{
    public class UserComment
    {

        public int CommentId { set; get; }
        public string CommentName { set; get; }
        public UserProfile UserProfile { set; get; }
        public UserPost UserPost { set; get; }
    }
}