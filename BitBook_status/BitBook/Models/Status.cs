using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitBook.Models
{
    public class Status
    {
        
        public int ProfileId { set; get; }
        public Profile Profile { set; get; }
        public string StatusName { get; set; }
       

       

        public string StatusUpdate { get; set; }

        public string UpdatedByFullName { get; set; }

        public Guid UserWhomStatusBelongsTo { get; set; }
    }

       
}
