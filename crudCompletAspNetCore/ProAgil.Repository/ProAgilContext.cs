using Microsoft.EntityFrameworkCore;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public class ProAgilContext : DbContext
    {
        public ProAgilContext(DbContextOptions<ProAgilContext> options) : base(options) { } //construtor

        //referenciando a classe Evento ao DataContext e gerando o nome para a tabela no sqlite
        public DbSet<Evento> Eventos { get; set; } // entidade evento
        public DbSet<Palestrante> Palestrantes { get; set; } // entidade palestrante
        public DbSet<PalestranteEvento> PalestrantesEventos { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<RedeSocial> RedeSocial { get; set; }

        // sobrescrevendo um método
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* dizendo para o modelBuilder quem sao as chaves no 
             * PalestranteEvento que é a entidade N:N entre Evento e Palestrante 
            */
            modelBuilder.Entity<PalestranteEvento>()
                       .HasKey(PE => new { PE.EventoId, PE.PalestranteId });
        }
    }
}