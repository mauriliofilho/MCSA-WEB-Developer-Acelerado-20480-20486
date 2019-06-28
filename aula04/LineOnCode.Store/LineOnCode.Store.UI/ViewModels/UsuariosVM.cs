using LineOnCode.Store.Domain.Entities;
using LineOnCode.Store.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.UI.ViewModels.Usuarios
{
    public class AddEditVM
    {
        [Required(ErrorMessage ="Campo Obrigatorio")]
        [StringLength(100, ErrorMessage ="Limite do {0} e {1}")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(20, ErrorMessage = "Limite do {0} e {1}")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(10, ErrorMessage = "Limite do {0} e {1}")]
        public string Senha { get; set; }
    }

    public static class ViewModelExtensions
    {
        public static AddEditVM ToUsuarioVM(this Usuario data)
        {
            return new AddEditVM() { Nome = data.Nome, Senha = data.Senha, UserName = data.UserName };
        }

        public static Usuario ToUsuario(this AddEditVM vm, int id = 0)
        {
            return new Usuario() { Id = id, Nome = vm.Nome, UserName = vm.UserName, Senha = vm.Senha.Encrypt() };
        }
    }
}
