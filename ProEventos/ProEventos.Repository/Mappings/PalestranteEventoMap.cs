using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProEventos.Domain.Models;

namespace ProEventos.Repository.Mappings
{
    public class PalestranteEventoMap : IEntityTypeConfiguration<PalestranteEvento>
    {
        public void Configure(EntityTypeBuilder<PalestranteEvento> builder)
        {
            builder.HasKey(pe => new {pe.EventoId, pe.PalestranteId});

            builder.HasOne(pe => pe.Evento)
                   .WithMany(pe => pe.PalestrantesEventos)
                   .HasForeignKey(pe => pe.EventoId).IsRequired();

            builder.HasOne(pe => pe.Palestrante)
                   .WithMany(pe => pe.PalestrantesEventos)
                   .HasForeignKey(pe => pe.PalestranteId).IsRequired();
            
            builder.ToTable("PalestrantesEventos");

        }
    }
}