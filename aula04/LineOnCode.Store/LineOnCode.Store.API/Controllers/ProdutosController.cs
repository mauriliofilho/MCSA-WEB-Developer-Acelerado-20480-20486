using LineOnCode.Store.API.ViewModels;
using LineOnCode.Store.Domain.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineOnCode.Store.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var produtos = (await _produtoRepository.GetWithCategoriaAsync()).Select(prod => prod.ToProdutoVM());
            return Ok(produtos);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProdutoById(int id)
        {
            var produtos = await _produtoRepository.GetWithCategoriaAsync(id);
            if (produtos == null) return NotFound();
            
            return Ok(produtos.ToProdutoVM());
        }

        [HttpPost]
        public IActionResult Add([FromBody]AddEditProdutoViewModel vm)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.Values);
            var produto = vm.ToProduto();
            _produtoRepository.Add(produto);
            return Ok(produto);
        }

        [HttpPut]
        public IActionResult Edit(int id,[FromBody]AddEditProdutoViewModel vm)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var produto = vm.ToProduto(id);
            _produtoRepository.Add(produto);
            return Ok(produto);
        }

    }
}
