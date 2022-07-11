using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProEventos.Domain.Models;

namespace ProEventos.Repository.Mappings
{
    public class PalestranteMap : IEntityTypeConfiguration<Palestrante>
    {
        public void Configure(EntityTypeBuilder<Palestrante> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).IsRequired();

            builder.Property(p => p.MiniCurriculo).IsRequired();

            builder.Property(p => p.ImagemURL).IsRequired();

            builder.Property(p => p.Telefone).IsRequired();

            builder.Property(p => p.Email).IsRequired();

            builder.HasMany(p => p.RedesSociais)
                   .WithOne(p => p.Palestrante)
                   .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasMany(p => p.PalestrantesEventos)
                   .WithOne(p => p.Palestrante);
            
            builder.ToTable("Palestrantes");
        }
    }
}