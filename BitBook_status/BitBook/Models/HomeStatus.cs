using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBook.Models
{
    public class HomeStatus
    {
        public int HomeStatusId { set; get; }
        public string StatusName { set; get; }
        
        public Profile Profile { set; get; }
    }
}