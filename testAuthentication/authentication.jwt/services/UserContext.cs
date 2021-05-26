using authentication.jwt.models;
using Microsoft.EntityFrameworkCore;

namespace authentication.jwt.services
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) {}

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                       .HasKey(e => new { e.Id });
        }
    }
}