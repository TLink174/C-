using Microsoft.EntityFrameworkCore;

namespace WebMVCDemo.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }
    }
}
