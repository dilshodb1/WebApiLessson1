using Microsoft.EntityFrameworkCore;
using WebApiLessson1.Models;
using WebApiLibrary.Models;

namespace WebApiLessson1.Persistence
{
    public class AppDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<History> Historys { get; set; }
        public DbSet<Post>Posts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Topbook> Topbooks { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }




    }
}
