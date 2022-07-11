using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProEventos.Domain.Models;

namespace ProEventos.Repository.Mappings
{
    public class RedeSocialMap : IEntityTypeConfiguration<RedeSocial>
    {
        public void Configure(EntityTypeBuilder<RedeSocial> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Nome).IsRequired();

            builder.Property(r => r.URL).IsRequired();

            builder.HasOne(r => r.Evento)
                   .WithMany(r => r.RedesSociais)
                   .HasForeignKey(r => r.EventoId);
            
            builder.HasOne(r => r.Palestrante)
                   .WithMany(r => r.RedesSociais)
                   .HasForeignKey(r => r.PalestranteId);
            
            builder.ToTable("RedesSociais");
        }
    }
}