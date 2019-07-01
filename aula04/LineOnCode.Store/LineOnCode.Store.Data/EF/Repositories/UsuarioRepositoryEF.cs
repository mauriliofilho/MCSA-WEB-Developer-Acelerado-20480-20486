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
    public class UsuarioRepositoryEF : RepositoryEF<Usuario>, IUsuarioRepository
    {
        public UsuarioRepositoryEF(StoreDataContext ctx) : base(ctx)
        {
        }

        public async Task<Usuario> GetUsuarioByUserNameAsync(string userName)
        {
            return await _db.FirstOrDefaultAsync(user => user.UserName == userName);
        }
    }
}
