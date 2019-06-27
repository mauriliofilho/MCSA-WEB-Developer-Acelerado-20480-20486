using LineOnCode.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.UI.ViewModels
{
    public class AddEditVM
    {

            [Required(ErrorMessage = "campo obrigatório")]
            [StringLength(100, ErrorMessage = "limite do {0} é {1}")]
            [Display(Name ="Nome")]
            public string Nome { get; set; }
            [Required(ErrorMessage = "campo obrigatório")]
            [Display(Name ="Valor Unitario")]
            public decimal? ValorUnitario { get; set; }

            [Required(ErrorMessage = "campo obrigatório")]
            [Display(Name ="Categoria do produto")]
            public int? CategoriaId { get; set; }

    }

    public static class ViewModeExtensions
    {
        public static Produto ToProduto(this AddEditVM vm, int id = 0)
        {
            return new Produto()
            {
                Id = id,
                Nome = vm.Nome,
                ValorUnitario = (decimal)vm.ValorUnitario,
                CategoriaId = (int)vm.CategoriaId
            };
        }

        public static AddEditVM ToProdutoVM(this Produto data)
        {
            return new AddEditVM()
            {
                Nome = data.Nome,
                ValorUnitario = (decimal)data.ValorUnitario,
                CategoriaId = (int)data.CategoriaId
            };
        }
    }

}
