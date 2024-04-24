using Microsoft.EntityFrameworkCore;
using BookShop.Models;

namespace BookShop
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
