using AuthenticationUsers.Business.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationUsers.Data.Context
{
    public class AuthenticationDbContext : DbContext
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options){}
        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasMany(u => u.Posts)
                        .WithOne(p => p.User)
                        .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Post>()
                        .HasOne(p => p.User)
                        .WithMany(u => u.Posts);

            modelBuilder.Entity<Post>()
                        .HasOne(p => p.User)
                        .WithMany(u => u.Posts)
                        .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
