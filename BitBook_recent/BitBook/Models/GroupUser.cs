using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBook.Models
{
    public class GroupUser
    {
        public string UserId { get; set; }
        public int GroupId { get; set; }
        public bool Admin { get; set; }
    }
}