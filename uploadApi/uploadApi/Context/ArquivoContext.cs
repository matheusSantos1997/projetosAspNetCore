using Microsoft.EntityFrameworkCore;
using uploadApi.Models;

namespace uploadApi.Context
{
    public class ArquivoContext : DbContext
    {
        public ArquivoContext(DbContextOptions<ArquivoContext> options): base(options){}

        public virtual DbSet<Arquivos> Arquivos { get; set; }

         protected override void OnModelCreating(ModelBuilder builder)
         {
             base.OnModelCreating(builder);
         }
    }
}