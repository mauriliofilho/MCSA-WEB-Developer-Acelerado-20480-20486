using Cadastros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Data
{
    public class CadastroDataContext : DbContext
    {
        public CadastroDataContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CadastroDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente() { Id = 1, Nome = "Maurilio", Idade = 34 },
                new Cliente() { Id = 2, Nome = "Vanessa", Idade = 30 },
                new Cliente() { Id = 3, Nome = "Marissa", Idade = 06 },
                new Cliente() { Id = 4, Nome = "Marissa", Idade = 06 }
                );
        }
    }
}
