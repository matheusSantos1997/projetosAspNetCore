using EFDomain;
using Microsoft.EntityFrameworkCore;

namespace EFRepository
{
    public class HeroiContext : DbContext
    {
        public HeroiContext(DbContextOptions<HeroiContext> options) : base(options) { }
        
        public DbSet<Heroi> Herois { get; set; }

        public DbSet<Batalha> Batalhas { get; set; }

        public DbSet<Arma> Armas { get; set; }

        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }

        public DbSet<IdentidadeSecreta> Identidade { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     // string conn = "Password=root;Persist Security Info=True;User ID=sa;Initial Catalog=HeroApp;Data Source=DESKTOP-O277TH6\\SQLEXPRESS";
        //     // optionsBuilder.UseSqlServer(conn);
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity => 
            {
                 entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
            });
        }
    }
}