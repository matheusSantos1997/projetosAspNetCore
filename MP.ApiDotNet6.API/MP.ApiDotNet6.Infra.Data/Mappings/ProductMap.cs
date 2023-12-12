using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MP.ApiDotNet6.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Infra.Data.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("produto");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("idproduto")
                .UseIdentityColumn();

            builder.Property(p => p.CodErp)
                .HasColumnName("coderp");

            builder.Property(x => x.Name)
                .HasColumnName("nome");

            builder.Property(x => x.Price)
                .HasColumnName("preco");

            builder.HasMany(p => p.Purchases)
                   .WithOne(c => c.Product)
                   .HasForeignKey(c => c.ProductId);
        }
    }
}
