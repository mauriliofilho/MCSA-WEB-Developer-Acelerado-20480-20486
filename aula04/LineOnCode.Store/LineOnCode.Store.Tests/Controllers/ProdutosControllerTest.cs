using LineOnCode.Store.Domain.Contracts.Repositories;
using LineOnCode.Store.Domain.Entities;
using LineOnCode.Store.UI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.Tests.Controllers
{
    [TestClass]
    public class ProdutosControllerTest
    {
        //Dado um produto Controller
        [TestMethod]
        public void OMetodoIndexDeveraRetornarUmaViewComProdutos()
        {
            //arrange
            var produtosCtrl = new ProdutosController(new ProdutoRespositoryFake(), new CategoriaRespositoryFake());

            //act
            var result = produtosCtrl.Index() as ViewResult;
            var model = result.Model as List<Produto>;

            //assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));

            Assert.IsNotNull(model);
            Assert.IsInstanceOfType(model, typeof(List<Produto>));
        }
    }

    public class ProdutoRespositoryFake : IProdutoRepository
    {
        public void Add(Produto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Produto entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Produto entity)
        {
            throw new NotImplementedException();
        }

        public Produto Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> GetWithCategoria()
        {
            return new List<Produto> { };
        }

        public Task<IEnumerable<Produto>> GetWithCategoriaAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetWithCategoriaAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
    public class CategoriaRespositoryFake : ICategoriaRepository
    {
        public void Add(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public Categoria Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categoria>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
