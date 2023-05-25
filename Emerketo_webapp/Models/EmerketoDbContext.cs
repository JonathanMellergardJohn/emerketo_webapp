using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Emerketo_webapp.Models
{
	// the argument <ApplicationUser> is passed as I've created a new class for handling identity 
    // that inherits from IdentityUser
	public class EmerketoDbContext : IdentityDbContext<ApplicationUser>
    {
        public EmerketoDbContext(DbContextOptions<EmerketoDbContext> options) : base(options) 
        { 

        }
        public DbSet<Product> Products { get; set; }
    }
}
