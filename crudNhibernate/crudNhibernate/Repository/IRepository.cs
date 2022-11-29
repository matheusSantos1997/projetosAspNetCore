using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudNhibernate.Repository
{
    public interface IRepository<T>
    {
        Task Add(T item);

        Task Remove(int id);

        Task Update(T item);

        Task<T> FindById(int id);

        Task<IEnumerable<T>> FindByName(string name);

        Task<IEnumerable<T>> FindAll();
    }
}
