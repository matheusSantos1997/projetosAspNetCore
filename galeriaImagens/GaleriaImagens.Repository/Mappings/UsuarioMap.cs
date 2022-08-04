using GaleriaImagens.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GaleriaImagens.Repository.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome).IsRequired();

            builder.Property(u => u.Email).IsRequired();

            builder.Property(u => u.CPF).IsRequired();

            builder.Property(u => u.Profissao).IsRequired();

            builder.Property(u => u.NomeUsuario).IsRequired();

            builder.Property(u => u.Senha).IsRequired();

            builder.HasMany(u => u.Imagens)
                   .WithOne(i => i.Usuario);

            builder.ToTable("Usuarios");
        }
    }
}