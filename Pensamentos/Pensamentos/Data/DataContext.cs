using Microsoft.EntityFrameworkCore;
using Pensamentos.Models;

namespace Pensamentos.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public virtual DbSet<Pensamento> Pensamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            string conn = configuration.GetConnectionString("defaultConnection");

            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
