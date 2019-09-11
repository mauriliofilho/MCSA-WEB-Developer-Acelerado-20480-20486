using LineOnCode.Store.Domain.Contracts.Repositories;
using LineOnCode.Store.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.Data.EF.Repositories
{
    public class ProdutoRepositoryEF : RepositoryEF<Produto>, IProdutoRepository
    {
        public ProdutoRepositoryEF(StoreDataContext ctx) : base(ctx)
        {
        }

        public IEnumerable<Produto> GetWithCategoria()
        {
            return _db.Include(x => x.Categoria).ToList();
        }

        public async Task<IEnumerable<Produto>> GetWithCategoriaAsync()
        {
            return await _db.Include(x => x.Categoria).ToListAsync();
        }

        public async Task<Produto> GetWithCategoriaAsync(int Id)
        {
            return await _db.Include(x => x.Categoria).FirstOrDefaultAsync(p => p.Id == Id);
        }
    }
}
