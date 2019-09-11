using LineOnCode.Store.Domain.Entities;
using LineOnCode.Store.Domain.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.Data.EF
{
    public static class DbInitializer
    {
        public static void Init(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria() { Id = 1, Nome = "Alimentos" },
                new Categoria() { Id = 2, Nome = "Higiene" },
                new Categoria() { Id = 3, Nome = "Vestuario" }
                );


            modelBuilder.Entity<Produto>().HasData(
                new Produto() { Id = 1, Nome = "Arroz", ValorUnitario = 11.9m, CategoriaId = 1, Descricao = "Comida Saldavel" },
                new Produto() { Id = 2, Nome = "Faijao", ValorUnitario = 5.9m, CategoriaId = 1, Descricao = "Comida Saldavel" },
                new Produto() { Id = 3, Nome = "Oleo", ValorUnitario = 2.9m, CategoriaId = 1, Descricao = "Comida Saldavel" },
                new Produto() { Id = 4, Nome = "Sal", ValorUnitario = 0.9m, CategoriaId = 1, Descricao = "Comida Saldavel" },
                new Produto() { Id = 5, Nome = "Fuba", ValorUnitario = 1.9m, CategoriaId = 1, Descricao = "Comida Saldavel" }
                );

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario() { Id = 1, Nome = "Admin", UserName = "Admin", Senha = "123456".Encrypt() },
                new Usuario() { Id = 2, Nome = "User", UserName = "User", Senha = "123".Encrypt() }
                );
        }
    }
}
