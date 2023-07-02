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
    public class ImagemMap : IEntityTypeConfiguration<Imagem>
    {
        public void Configure(EntityTypeBuilder<Imagem> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Nome).IsRequired().HasColumnType("varchar(50)");

            builder.Property(i => i.URLImagem).IsRequired().HasColumnType("varchar(255)");

            builder.Property(i => i.SalvoEm);

            builder.HasOne(i => i.Post)
                   .WithOne(p => p.Imagem)
                   .HasForeignKey<Imagem>(i => i.PostId);

            builder.ToTable("Imagens");
        }
    }
}
