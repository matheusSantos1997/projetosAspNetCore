using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProceduresStorage.API.Models;

namespace ProceduresStorage.API.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
           
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
            
            string conn = configuration.GetConnectionString("localConnection");

            optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);
        }
    }
}