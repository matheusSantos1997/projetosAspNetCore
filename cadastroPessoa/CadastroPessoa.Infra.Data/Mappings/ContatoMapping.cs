using CadastroPessoa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroPessoa.Infra.Data.Mappings
{
    public class ContatoMapping : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("contatos");

            builder.HasKey(c => c.IdContato);

            builder.Property(c => c.IdContato)
                   .HasColumnName("idContato");
            
            builder.Property(c => c.NomeContato)
                   .HasColumnName("nomeContato")
                   .IsRequired();

            builder.Property(c => c.Telefone)
                   .HasColumnName("telefone")
                   .IsRequired();
            
            builder.Property(c => c.PessoaId)
                   .HasColumnName("pessoaId");
            
            builder.HasOne(c => c.Pessoa)
                   .WithOne(pe => pe.Contato)
                   .HasForeignKey<Pessoa>(pe => pe.ContatoId)
                   .HasConstraintName("FK_Pessoa_ContatoId");
        }
    }
}