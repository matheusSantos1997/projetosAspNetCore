using crudDapperEfCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.NomeCliente).IsRequired().HasMaxLength(50);

            builder.Property(c => c.Email).IsRequired().HasMaxLength(90);

            builder.Property(c => c.Endereco).IsRequired().HasMaxLength(40);

            builder.HasMany(c => c.Produtos)
                   .WithOne(c => c.Cliente)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Clientes");
        }
    }
}
