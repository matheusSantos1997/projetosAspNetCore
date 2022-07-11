using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProEventos.Domain.Models;
using ProEventos.Repository.Mappings;

namespace ProEventos.Repository.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public virtual DbSet<Evento> Eventos { get; set; }

        public virtual DbSet<Lote> Lotes { get; set; }

        public virtual DbSet<Palestrante> Palestrantes { get; set; }

        public virtual DbSet<PalestranteEvento> PalestrantesEventos { get; set; }

        public virtual DbSet<RedeSocial> RedesSociais { get; set; }

        // conexao com o banco
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             IConfigurationRoot configuration = new ConfigurationBuilder()
                  .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                  .AddJsonFile("appsettings.json")
                  .Build();

             optionsBuilder.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
             // optionsBuilder.EnableSensitiveDataLogging();
            // optionsBuilder.UseSqlite("Data Source=UsersDB.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new EventoMap());
            builder.ApplyConfiguration(new PalestranteEventoMap());
            builder.ApplyConfiguration(new PalestranteMap());
            builder.ApplyConfiguration(new LoteMap());
            builder.ApplyConfiguration(new RedeSocialMap());
        }
    }
}