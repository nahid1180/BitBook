using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BitBook.Models
{
    public class StatusDb:DbContext
    {
        public StatusDb() : base("DefaultConnection")
        {
            
        }
        DbSet<HomeStatus> Statuses { set; get; } 
    }
}