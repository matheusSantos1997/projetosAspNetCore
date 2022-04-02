using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using registerUsers.Models;

namespace registerUsers.mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.IdUsuario);

            builder.Property(u => u.Name).IsRequired();

            builder.Property(u => u.Email).IsRequired();

            builder.Property(u => u.Telefone).IsRequired();

            builder.HasMany(u => u.Contas)
                   .WithOne(u => u.Usuario)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);
            
            builder.ToTable("Usuarios");
        }
    }
}