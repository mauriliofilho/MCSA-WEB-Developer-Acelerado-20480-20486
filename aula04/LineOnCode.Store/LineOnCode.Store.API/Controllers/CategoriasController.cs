using LineOnCode.Store.Domain.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineOnCode.Store.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriasController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _categoriaRepository.GetAllAsync();
            return Ok(
                        data.Select(cat => new { cat.Id, cat.Nome})
                     );
        }
    }
}
