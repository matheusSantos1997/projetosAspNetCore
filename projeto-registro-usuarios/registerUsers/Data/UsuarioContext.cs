using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using registerUsers.mappings;
using registerUsers.Models;

namespace registerUsers.Data
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options){ }

        public virtual DbSet<Usuario> Usuarios {get; set; }

        public virtual DbSet<Conta> Contas { get; set; }
        
        // conexao com o banco
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             IConfigurationRoot configuration = new ConfigurationBuilder()
                  .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                  .AddJsonFile("appsettings.json")
                  .Build();

             optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnectionMySql"));
             // optionsBuilder.EnableSensitiveDataLogging();
            // optionsBuilder.UseSqlite("Data Source=UsersDB.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
           builder.ApplyConfiguration(new UsuarioMap());

           builder.ApplyConfiguration(new ContaMap());
            
        }
        
    }
}