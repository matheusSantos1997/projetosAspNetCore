using ConsultaExemplo.Models;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Data;

namespace ConsultaExemplo.Data
{
#nullable disable
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        public DbSet<People> Peoples { get; set; }

        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                  .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                  .AddJsonFile("appsettings.json")
                  .Build();

            string conn = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
        }

        public static IDbConnection GetConnetion()
        {
            try
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                  .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                  .AddJsonFile("appsettings.json")
                  .Build();

                string conn = configuration.GetConnectionString("DefaultConnection");

                return new MySqlConnection(conn);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>()
           .HasOne(c => c.People)
           .WithMany(p => p.Cars)
           .HasForeignKey(c => c.PeopleId);
        }
    }
}
