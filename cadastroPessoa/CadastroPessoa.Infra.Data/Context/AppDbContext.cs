using CadastroPessoa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CadastroPessoa.Infra.Data.Context
{
    public sealed class AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : DbContext(options)
    {
        private readonly IConfiguration _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

        public required DbSet<Pessoa> Pessoas { get; set; }

        public required DbSet<Produto> Produtos { get; set; }

        public required DbSet<Contato> Contatos { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection")).EnableSensitiveDataLogging();
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach(var realationShip in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var foreignKey in realationShip.GetForeignKeys())
                {
                    foreignKey.DeleteBehavior = DeleteBehavior.Cascade;
                }
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}