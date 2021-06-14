using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.interfaces
{
    public interface IGeralPersistence
    {
        // GERAL
        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        void DeleteRange<T>(T[] entity) where T : class;

        Task<bool> SaveChangesAsync();
    }
}
