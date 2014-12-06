using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BitbookApp.Models
{
    public class BitBookDbContext : DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}