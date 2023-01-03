using crudDapperEfCore.Mappings;
using crudDapperEfCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace crudDapperEfCore.DBConnections
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

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

        // dapper connection
        public static IDbConnection GetConnetion()
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

            modelBuilder.ApplyConfiguration(new ClienteMap());

            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }
    }
}
