using Microsoft.EntityFrameworkCore;
using MP.ApiDotNet6.Domain.Models;

namespace MP.ApiDotNet6.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        public DbSet<Person> People { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Purchase> Purchase { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

    }
}
