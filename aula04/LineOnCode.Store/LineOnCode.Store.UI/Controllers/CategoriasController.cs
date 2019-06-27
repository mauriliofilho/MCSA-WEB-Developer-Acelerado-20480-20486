using LineOnCode.Store.Domain.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.UI.Controllers
{
    public class CategoriasController  : Controller
    {
        private readonly ICategoriaRepository _catRepository;

        public CategoriasController(ICategoriaRepository catRepository)
        {
            _catRepository = catRepository;
        }
        public IActionResult Index()
        {
            var categoria = _catRepository.GetAll();
            return View(categoria);
        }
    }
}
