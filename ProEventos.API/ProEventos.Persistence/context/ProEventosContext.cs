using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;

namespace ProEventos.Persistence.context
{
    public class ProEventosContext : DbContext
    {
        public ProEventosContext(DbContextOptions<ProEventosContext> options) : base(options) {} // método constructor do contexto

        public DbSet<Evento> Eventos { get; set; } // tabela de Eventos

        public DbSet<Lote> Lotes { get; set; } // tabela de Lotes

        public DbSet<Palestrante> Palestrantes { get; set; } // tabela de Palestrantes

        public DbSet<PalestranteEvento> PalestrantesEventos { get; set; } // tabela PalestrantesEventos 

        public DbSet<RedeSocial> RedesSociais { get; set; } // tabela RedesSociais

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PalestranteEvento>()
                        .HasKey(PE => new { PE.EventoId, PE.PalestranteId }); // quando tem relacionamento de n:n 

            // deletando em cascata quando uma tabela possuir duas chaves estrangeiras no relacionamento
            modelBuilder.Entity<Evento>()
                        .HasMany(e => e.RedesSociais)
                        .WithOne(rs => rs.Evento)
                        .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<Palestrante>()
                        .HasMany(p => p.RedeSocials)
                        .WithOne(rs => rs.Palestrante)
                        .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
