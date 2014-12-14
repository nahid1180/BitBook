using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace BitBook.Models
{
    public class ProfileDb:DbContext
    {
       
        public DbSet<Status> Statuses { set; get; }
        public DbSet<Profile> UserProfiles { set; get; }
    }
}