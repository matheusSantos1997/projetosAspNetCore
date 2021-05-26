using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProAgil.Domain;
using ProAgil.Domain.Identity;

namespace ProAgil.Repository
{
    public class ProAgilContext : IdentityDbContext<User, Role, int, 
                   IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, 
                   IdentityRoleClaim<int>, IdentityUserToken<int>>
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
            base.OnModelCreating(modelBuilder);
            
            // vai dizer que as classes entity vai ter relacionamentos entre a classe UserRole
            modelBuilder.Entity<UserRole>(userRole => 
                {
                    userRole.HasKey(ur => new {ur.UserId, ur.RoleId}); 

                    // dentro de Role tem muitos userRoles
                    userRole.HasOne(ur => ur.Role)
                            .WithMany(r => r.UserRoles)
                            .HasForeignKey(ur => ur.RoleId)
                            .IsRequired();

                    userRole.HasOne(ur => ur.User)
                            .WithMany(r => r.UserRoles)
                            .HasForeignKey(ur => ur.UserId)
                            .IsRequired();
                }
            );
            /* dizendo para o modelBuilder quem sao as chaves no 
             * PalestranteEvento que é a entidade N:N entre Evento e Palestrante 
            */
            modelBuilder.Entity<PalestranteEvento>()
                       .HasKey(PE => new { PE.EventoId, PE.PalestranteId });
        }
    }
}