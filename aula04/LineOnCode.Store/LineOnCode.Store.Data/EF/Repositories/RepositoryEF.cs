using LIneOnCode.Store.Domain.Contracts.Repositories;
using LIneOnCode.Store.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.Data.EF.Repositories
{
    public class RepositoryEF<T> : IRepository<T> where T:Entity
    {
        private readonly StoreDataContext _ctx;
        protected readonly DbSet<T> _db;

        public RepositoryEF(StoreDataContext ctx)
        {
            _ctx = ctx;
            _db = _ctx.Set<T>();
        }
        public void Add(T entity)
        {
            _db.Add(entity);
            _ctx.SaveChanges();
        }

        public void Delete(T entity)
        {
            _db.Remove(entity);
            _ctx.SaveChanges();
        }

        public void Edit(T entity)
        {
            _ctx.Update(entity);
            _ctx.SaveChanges();
        }

        public T Get(int id)
        {
            return _db.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _db.ToList();
        }
    }
}
