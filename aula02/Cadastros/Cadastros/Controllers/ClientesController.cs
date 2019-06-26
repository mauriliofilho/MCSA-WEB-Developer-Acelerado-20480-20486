using Cadastros.Data;
using Cadastros.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Controllers
{
    public class ClientesController : Controller
    {
        private CadastroDataContext _ctx = new CadastroDataContext();
        public ViewResult Index()
        {
            
            var clientes = _ctx.Clientes.ToList();

            //clientes.Add(new Cliente() { Id = 1, Nome = "Maurilio", Idade = 10 });
            return View(clientes);
        }
        [HttpGet]
        public ViewResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(Cliente cliente)
        {
            _ctx.Clientes.Add(cliente);
            _ctx.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var cliente = _ctx.Clientes.Find(id);
            if (cliente == null) return NotFound();
            
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(Cliente cliente)
        {
            _ctx.Update(cliente);
            _ctx.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult Excluir(int id)
        {
            var cliente = _ctx.Clientes.Find(id);

            if (cliente == null) return NotFound();

            _ctx.Remove(cliente);
            _ctx.SaveChanges();

            return NoContent();
            
        }

    }
}
