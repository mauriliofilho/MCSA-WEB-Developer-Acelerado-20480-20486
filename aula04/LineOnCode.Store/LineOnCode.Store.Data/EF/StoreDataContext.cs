using LineOnCode.Store.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.Data.EF
{
    public class StoreDataContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public StoreDataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("StoreDbConn"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria() { Id=1, Nome="Alimentos"},
                new Categoria() { Id=2, Nome="Higiene"},
                new Categoria() { Id=3, Nome="Vestuario"}
                );


            modelBuilder.Entity<Produto>().HasData(
                new Produto() { Id = 1, Nome = "Arroz", ValorUnitario = 11.9m, CategoriaId=1 },
                new Produto() { Id = 2, Nome = "Faijao", ValorUnitario = 5.9m, CategoriaId=1 },
                new Produto() { Id = 3, Nome = "Oleo", ValorUnitario = 2.9m, CategoriaId=1 },
                new Produto() { Id = 4, Nome = "Sal", ValorUnitario = 0.9m, CategoriaId=1 },
                new Produto() { Id = 5, Nome = "Fuba", ValorUnitario = 1.9m, CategoriaId=1 }
                );
        }
    }
}
