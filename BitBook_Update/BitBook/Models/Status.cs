using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitBook.Models
{
    public class Status
    {
        public Status()
        {
            Id = Guid.NewGuid();
        }

        public string StatusName { get; set; }
        public Guid Id { get; set; }

        public DateTime TimeOfUpdate { get; set; }

        public string StatusUpdate { get; set; }

        public string UpdatedByFullName { get; set; }

        public Guid UserWhomStatusBelongsTo { get; set; }
    }

       
}
