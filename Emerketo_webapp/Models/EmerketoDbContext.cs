using Microsoft.EntityFrameworkCore;

namespace Emerketo_webapp.Models
{
    public class EmerketoDbContext : DbContext
    {
        public EmerketoDbContext(DbContextOptions<EmerketoDbContext> options) : base(options) 
        { 

        }
        public DbSet<Product> Products { get; set; }
    }
}
