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
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Titulo).IsRequired().HasColumnType("varchar(50)");

            builder.Property(p => p.Conteudo).IsRequired().HasColumnType("varchar(50)");

            builder.HasOne(p => p.Usuario)
                   .WithMany(u => u.Posts)
                   .HasForeignKey(p => p.UsuarioId);

            builder.HasOne(u => u.Imagem)
                   .WithOne(i => i.Post);

            builder.ToTable("Posts");
        }
    }
}
