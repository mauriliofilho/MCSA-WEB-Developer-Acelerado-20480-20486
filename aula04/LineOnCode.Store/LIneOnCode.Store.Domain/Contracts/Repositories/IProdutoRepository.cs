﻿using LineOnCode.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.Domain.Contracts.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IEnumerable<Produto> GetWithCategoria();
        Task<IEnumerable<Produto>> GetWithCategoriaAsync();
        Task<Produto> GetWithCategoriaAsync(int Id);
    }
}
