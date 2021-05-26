using crud_webapi.Domain;
using Microsoft.EntityFrameworkCore;

namespace crud_webapi.Repository
{
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options) : base(options) { } //construtor

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                       .HasKey(e => new { e.IdUsuario });
        }
    }
}