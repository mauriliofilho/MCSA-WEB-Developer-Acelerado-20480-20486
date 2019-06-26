using LineOnCode.Store.Data.EF;
using LIneOnCode.Store.Domain.Contracts.Repositories;
using LIneOnCode.Store.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.UI.Controllers
{
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
            Produto produto = null;

            if (id != null)
            {
                produto = _prodRepository.Get((int)id);
            }
            ViewBag.Categoria = _catRepository.GetAll();
            //ViewData["Categoria"] = _catRepository.GetAll();
            return View(produto);
        }

        [HttpPost]
        public IActionResult AddEdit(Produto model)
        {
            if (model.Id > 0)
            {
                _prodRepository.Edit(model);
            }
            else
            {
                _prodRepository.Add(model);
            }
            return RedirectToAction("Index");

        }
    }
}
