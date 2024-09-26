using crudDapperEfCore.API.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace crudDapperEfCore.API.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.NomeProduto).IsRequired().HasMaxLength(50);

            builder.Property(p => p.TipoProduto).IsRequired().HasMaxLength(50);

            builder.Property(p => p.Preco).IsRequired();

            builder.HasOne(p => p.Cliente)
                   .WithMany(c => c.Produtos)
                   .HasForeignKey(p => p.ClienteId);

            builder.ToTable("Produtos");
        }
    }
}