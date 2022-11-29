using System;
using GaleriaImagens.Business.Models;
using GaleriaImagens.Repository.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GaleriaImagens.Repository.Context
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options): base(options){}

        public virtual DbSet<Usuario> Usuarios { get; set; }

        public virtual DbSet<Imagem> Imagens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                  .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                  .AddJsonFile("appsettings.json")
                  .Build();

            string localConnection = configuration.GetConnectionString("localConnection");
            
            optionsBuilder.UseNpgsql(localConnection);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UsuarioMap());
            builder.ApplyConfiguration(new ImagemMap());
        }
    }
}