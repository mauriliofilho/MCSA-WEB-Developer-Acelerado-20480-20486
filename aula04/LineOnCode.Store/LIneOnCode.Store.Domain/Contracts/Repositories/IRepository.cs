using LineOnCode.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.Domain.Contracts.Repositories
{
    public interface IRepository<T> where T:Entity
    {
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);

        T Get(int id);
        Task<T> GetAsync(int id);
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
    }
}
