using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeOneToOne.models;

namespace testeOneToOne.context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options){}
        
        public DbSet<UserOne> UsersOne { get; set; }

        public DbSet<UserTwo> UsersTwo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserOne>()
                .HasOne(a => a.UserTwo)
                .WithOne(b => b.UserOne)
                .HasForeignKey<UserTwo>(b => b.UserOneRef);

            // deletando via cascata usando permitindo deletar a tabela junto com a chave estrangeira do registro da outra tabela
            modelBuilder.Entity<UserOne>()
                        .HasOne(u => u.UserTwo)
                        .WithOne(u => u.UserOne)
                        .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
