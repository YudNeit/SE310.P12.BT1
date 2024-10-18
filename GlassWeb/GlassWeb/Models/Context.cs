using Microsoft.EntityFrameworkCore;

namespace GlassWeb.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
