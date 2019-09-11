using LineOnCode.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LineOnCode.Store.API.ViewModels
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CategoriaId { get; set; }
        public string CategoriaName { get; set; }
        public decimal ValorUnitario { get; set; }

    }

    public class AddEditProdutoViewModel
    {
        [Required(ErrorMessage ="Campo Obrig")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrig")]
        public int? CategoriaId { get; set; }
        [Required(ErrorMessage = "Campo Obrig")]
        public decimal ValorUnitario { get; set; }

    }

    public static class ViewModelExtensions
    {
        public static ProdutoViewModel ToProdutoVM(this Produto produto)
        {
            return new ProdutoViewModel
            {
                Id = produto.Id,
                Nome = produto.Nome,
                CategoriaId = produto.CategoriaId,
                CategoriaName = produto.Categoria.Nome,
                ValorUnitario = produto.ValorUnitario
            };
        }


        public static Produto ToProduto(this AddEditProdutoViewModel data, int id = 0)
        {
            return new Produto
            {
                Id = id,
                Nome = data.Nome,
                CategoriaId = (int)data.CategoriaId,
                ValorUnitario = data.ValorUnitario
            };
        }
    }
}
