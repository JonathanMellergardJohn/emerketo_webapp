using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Emerketo_webapp.Models
{
    public class EmerketoDbContext : IdentityDbContext
    {
        public EmerketoDbContext(DbContextOptions<EmerketoDbContext> options) : base(options) 
        { 

        }
        public DbSet<Product> Products { get; set; }
    }
}
