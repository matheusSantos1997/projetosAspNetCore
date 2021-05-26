using System;
using Microsoft.EntityFrameworkCore;


namespace Gamer_info_webapi.model
{
    public partial class GameDbContext : DbContext
    { 
        
        // método construtor
        public GameDbContext(DbContextOptions<GameDbContext> options)
            : base(options) {}

        public DbSet<Game> Game { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasKey(e => e.IdGame);

                entity.Property(e => e.DataLancamento).HasColumnType("date");

                entity.Property(e => e.Imagem)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("pk_IdUsuario");

                entity.Property(e => e.Cep)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DataNasc).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGameNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdGame)
                    .HasConstraintName("FK__Usuario__IdGame__286302EC");
            });
        }
    }
}
