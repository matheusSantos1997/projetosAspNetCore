using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using registerUsers.Models;

namespace registerUsers.mappings
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.HasKey(c => c.IdConta);
            builder.HasIndex(c => c.IdConta).IsUnique();

            builder.Property(c => c.Agencia).IsRequired();

            builder.Property(c => c.ContaCorrente).IsRequired();
            builder.HasIndex(c => c.ContaCorrente).IsUnique();

            builder.HasOne(c => c.Usuario)
                   .WithMany(c => c.Contas)
                   .HasForeignKey(c => c.UsuarioId)
                   .OnDelete(DeleteBehavior.Cascade);
            
            builder.ToTable("Contas");
        }
    }
}