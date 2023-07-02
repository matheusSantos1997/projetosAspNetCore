using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postagens.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postagens.Repository.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome).IsRequired().HasColumnType("varchar(50)");

            builder.Property(u => u.Telefone).IsRequired().HasColumnType("varchar(50)");

            builder.Property(u => u.CPF).IsRequired().HasColumnType("varchar(50)");

            builder.Property(u => u.Email).IsRequired().HasColumnType("varchar(50)");

            builder.Property(u => u.Senha).IsRequired().HasColumnType("varchar(50)");

            builder.HasMany(u => u.Posts)
                   .WithOne(p => p.Usuario);

            builder.ToTable("Usuarios");
        }
    }
}
