using GaleriaImagens.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GaleriaImagens.Repository.Mappings
{
    public class ImagemMap : IEntityTypeConfiguration<Imagem>
    {
        public void Configure(EntityTypeBuilder<Imagem> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Nome).IsRequired();

            builder.Property(i => i.URLImagem).IsRequired();

            builder.Property(i => i.SavedAt);

            builder.HasOne(i => i.Usuario)
                   .WithMany(i => i.Imagens)
                   .HasForeignKey(i => i.UsuarioId);
            
            builder.ToTable("Imagens");


        }
    }
}