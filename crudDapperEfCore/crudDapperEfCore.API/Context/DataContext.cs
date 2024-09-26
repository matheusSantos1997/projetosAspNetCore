using System.Data;
using System.Data.SqlClient;
using crudDapperEfCore.API.models;
using Microsoft.EntityFrameworkCore;

namespace crudDapperEfCore.API.Context
{
    public class DataContext : DbContext
    {
        #nullable disable
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                   .AddJsonFile("appsettings.json")
                   .Build();
            
            string conn = configuration.GetConnectionString("localConnection");

            optionsBuilder.UseSqlServer(conn);
        }

        public static IDbConnection GetConnection()
        {
            try
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                  .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                  .AddJsonFile("appsettings.json")
                  .Build();

                string conn = configuration.GetConnectionString("localConnection");

                return new SqlConnection(conn);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }
}