using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBook.Models
{
    public class Support
    {
        public int SupportId { get; set; }

        public int StatusId { get; set; }

        public string UserId { get; set; }

        public virtual Status Status { get; set; }

        public DateTime SupportedDate { get; set; }
    }
}