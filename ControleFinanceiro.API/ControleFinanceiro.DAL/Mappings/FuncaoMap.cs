using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mappings
{
    public class FuncaoMap : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd(); // para permitir chave seja auto incrementavel no Id da Role
            
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(50);

            builder.HasData(
                new Funcao
                {
                    Id = Guid.NewGuid().ToString(), // Guid.NewGuid() vai gerar uma hash em string
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR",
                    Descricao = "Administrador do Sistema"
                },
                new Funcao
                {
                    Id = Guid.NewGuid().ToString(), // Guid.NewGuid() vai gerar uma hash em string
                    Name = "Usuario",
                    NormalizedName = "USUARIO",
                    Descricao = "Usuário do Sistema"
                });

            builder.ToTable("funcoes");
        }
    }
}
