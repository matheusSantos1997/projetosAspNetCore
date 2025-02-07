using CadastroPessoa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroPessoa.Infra.Data.Mappings
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("pessoas");

            builder.HasKey(pe => pe.IdPessoa);

            builder.Property(pe => pe.IdPessoa)
                   .HasColumnName("idPessoa");
            
            builder.Property(pe => pe.NomePessoa)
                   .HasColumnName("nomePessoa")
                   .IsRequired();
            
            builder.Property(pe => pe.Email)
                   .HasColumnName("email")
                   .IsRequired();
            
            builder.Property(pe => pe.Documento)
                   .HasColumnName("documento")
                   .IsRequired();
            
            builder.Property(pe => pe.ContatoId)
                   .HasColumnName("contatoId");
            
            builder.HasOne(pe => pe.Contato)
                   .WithOne(c => c.Pessoa)
                   .HasForeignKey<Contato>(c => c.PessoaId)
                   .HasConstraintName("FK_Contato_PessoaId");
            
            builder.HasMany(pe => pe.Produtos)
                   .WithOne(po => po.Pessoa)
                   .HasForeignKey(po => po.PessoaId)
                   .HasConstraintName("FK_Produto_PessoaId");
        }
    }
}