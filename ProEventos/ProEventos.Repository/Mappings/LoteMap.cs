using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProEventos.Domain.Models;

namespace ProEventos.Repository.Mappings
{
    public class LoteMap : IEntityTypeConfiguration<Lote>
    {
        public void Configure(EntityTypeBuilder<Lote> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Nome).IsRequired();

            builder.Property(l => l.Preco).IsRequired();

            builder.Property(l => l.DataInicio);

            builder.Property(l => l.DataFim);

            builder.Property(l => l.Quantidade).IsRequired();

            builder.HasOne(l => l.Evento)
                   .WithMany(l => l.Lotes)
                   .HasForeignKey(l => l.EventoId)
                   .IsRequired();

            builder.ToTable("Lotes");
        }
    }
}