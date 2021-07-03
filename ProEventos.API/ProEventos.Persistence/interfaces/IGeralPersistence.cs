using System.Threading.Tasks;

namespace ProEventos.Persistence.interfaces
{
    public interface IGeralPersistence
    {
        // GERAL
        void Add<T>(T entity) where T : class; // T genérico onde T é uma classe

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        void DeleteRange<T>(T[] entity) where T : class;

        Task<bool> SaveChangesAsync();
    }
}
