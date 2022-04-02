using System.Collections.Generic;
using System.Threading.Tasks;
using registerUsers.Models;

namespace registerUsers.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetAll();

        Task<Usuario> GetById(int id);

        Task<List<Usuario>> GetByName(string name);

        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Remove<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();
    }
}