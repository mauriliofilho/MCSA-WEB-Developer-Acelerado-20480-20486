using LineOnCode.Store.Data.EF;
using LineOnCode.Store.UI.ViewModels;
using LineOnCode.Store.Domain.Contracts.Repositories;
using LineOnCode.Store.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace LineOnCode.Store.UI.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepository _prodRepository;
        private readonly ICategoriaRepository _catRepository;

        public ProdutosController(IProdutoRepository prodRepository, ICategoriaRepository catRepository)
        {
            _prodRepository = prodRepository;
            _catRepository = catRepository;
        }
        public IActionResult Index()
        {
            var produtos = _prodRepository.GetWithCategoria();

            return View(produtos); ;
        }

        [HttpGet]
        public IActionResult AddEdit(int? id)
        {
            AddEditVM produto = null;

            if (id != null)
            {
                var data = _prodRepository.Get((int)id);
                if (data == null) return NotFound();

                produto = data.ToProdutoVM();
            }
            loadCategoria();
            //ViewData["Categoria"] = _catRepository.GetAll();
            return View(produto);
        }

        private void loadCategoria()
        {
            ViewBag.Categoria = _catRepository.GetAll().Select(x => new SelectListItem(x.Nome, x.Id.ToString()));
        }

        [HttpPost]
        public IActionResult AddEdit(int Id, AddEditVM model)
        {
            if (!ModelState.IsValid)
            {
                loadCategoria();
                return View(model);
            }

            if (Id == 0)
            {
                _prodRepository.Add(model.ToProduto());
            }
            else
            {
                _prodRepository.Edit(model.ToProduto(Id));
            }
            return RedirectToAction("Index");

        }

        [HttpDelete]
        public IActionResult Excluir(int id)
        {
            var data = _prodRepository.Get(id);

            if (data == null) return NotFound();

            _prodRepository.Delete(data);
            return NoContent();
        }
    }
}
