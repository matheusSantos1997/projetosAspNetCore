using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationUsers.Data.Interface
{
    public interface IGenericRepository
    {
        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Remove<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();
    }
}
