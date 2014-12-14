using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BitBook.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FavoritePhrase { get; set; }
        public bool MadeProfileYet { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<BitBook.Models.Status> Status { get; set; }
        
    }
}