using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitBook.Models
{
    public class Update
    {
        [ScaffoldColumn(false)]
        public int UpdateId { get; set; }

        public string Updatemsg { get; set; }

        

        public int StatusId { get; set; }

        public DateTime UpdateDate { get; set; }

        public virtual Status Status { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

       // public virtual ICollection<UpdateSupport> UpdateSupports { get; set; }

        public Update()
        {
            UpdateDate = DateTime.Now;

        }
    }
}