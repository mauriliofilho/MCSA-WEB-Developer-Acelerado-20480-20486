﻿using LineOnCode.Store.Domain.Contracts.Repositories;
using LineOnCode.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.Data.EF.Repositories
{
    public class CategoriaRepositoryEF : RepositoryEF<Categoria>, ICategoriaRepository
    {
        public CategoriaRepositoryEF(StoreDataContext ctx) : base(ctx)
        {

        }
    }
}
