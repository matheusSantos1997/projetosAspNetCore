using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProEventos.Domain.Models;

namespace ProEventos.Repository.Mappings
{
    public class EventoMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Local).IsRequired();

            builder.Property(e => e.DataEvento);

            builder.Property(e => e.Tema).IsRequired();

            builder.Property(e => e.QtdPessoas).IsRequired();

            builder.Property(e => e.Telefone).IsRequired();

            builder.Property(e => e.Email).IsRequired();

            builder.HasMany(e => e.Lotes)
                   .WithOne(e => e.Evento);
            
            builder.HasMany(e => e.RedesSociais)
                   .WithOne(e => e.Evento)
                   .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasMany(e => e.PalestrantesEventos)
                   .WithOne(e => e.Evento);
            
            builder.ToTable("Eventos");
        }
    }
}