using LineOnCode.Store.Domain.Contracts.Repositories;
using LineOnCode.Store.Domain.Helpers;
using LineOnCode.Store.UI.ViewModels.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LineOnCode.Store.UI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public AuthController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginVM loginVM)
        {
            var usuario = await _usuarioRepository.GetUsuarioByUserNameAsync(loginVM.UserName);
            if (usuario == null)
            {
                ModelState.AddModelError("UserName", "Login não Cadastrado");
                return View(loginVM);
            }

            if (usuario.Senha != loginVM.Password.Encrypt())
            {
                ModelState.AddModelError("Senha", "Senha Incorreta");
                return View(loginVM);
            }

            if (ModelState.IsValid)
            {
                await LogarUsuario(usuario.Nome, usuario.UserName);
                return RedirectToAction("Index", "Home");
            }

            return View(loginVM);
        }

        //public async IActionResult SignOut()
        //{
        //    return await View();
        //}

        public IActionResult UserInformation()
        {
            return View();
        }

        private async Task LogarUsuario(string nome, string userName)
        {
            var claims = new List<Claim>()
            {
                new Claim("nome", nome),
                new Claim("username", userName),
                new Claim("roles", "admin")
            };
            var identity = new ClaimsIdentity(claims, 
                                              CookieAuthenticationDefaults.AuthenticationScheme,
                                              "nome",
                                              "roles");
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(principal);
        }
    }
}
