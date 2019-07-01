using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LineOnCode.Store.UI.ViewModels.Auth
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Login")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Senha")]
        public string Password { get; set; }
        [Display(Name = "Lembrar")]
        public bool RememberMe { get; set; }
    }
}
