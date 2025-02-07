using CadastroPessoa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroPessoa.Infra.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produtos");

            builder.HasKey(po => po.IdProduto);

            builder.Property(po => po.IdProduto)
                   .HasColumnName("idProduto");
            
            builder.Property(po => po.NomeProduto)
                   .HasColumnName("nomeProduto")
                   .IsRequired();
            
            builder.Property(po => po.TipoProduto)
                   .HasColumnName("tipoProduto")
                   .IsRequired();
            
            builder.Property(po => po.Preco)
                   .HasColumnName("preco")
                   .IsRequired();
            
            builder.Property(po => po.PessoaId)
                   .HasColumnName("pessoaId");
            
            builder.HasOne(po => po.Pessoa)
                   .WithMany(pe => pe.Produtos);
        }
    }
}