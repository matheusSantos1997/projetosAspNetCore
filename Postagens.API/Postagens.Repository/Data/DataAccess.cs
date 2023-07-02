using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using Postagens.Domain.Models;
using Postagens.Repository.Mappings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postagens.Repository.Data
{
    public class DataAccess : DbContext
    {
        public DataAccess(DbContextOptions<DataAccess> options): base(options) { }
        
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Imagem> Imagens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                 .AddJsonFile("appsettings.json")
                 .Build();

            string connection = configuration.GetConnectionString("localConnection");

            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }

        public static IDbConnection GetConnection()
        {
            try
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                  .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                  .AddJsonFile("appsettings.json")
                  .Build();

                string connection = configuration.GetConnectionString("localConnection");

                return new MySqlConnection(connection);
            }
            catch(MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioMap());

            modelBuilder.ApplyConfiguration(new PostMap());

            modelBuilder.ApplyConfiguration(new ImagemMap());
        }
    }
}
