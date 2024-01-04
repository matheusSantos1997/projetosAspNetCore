using CrudContatosMvc.Mappings;
using CrudContatosMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudContatosMvc.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options): base(options) { }

        public DbSet<ContatoModel> Contatos { get; set; }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ContatoMap());
        }
    }
}
