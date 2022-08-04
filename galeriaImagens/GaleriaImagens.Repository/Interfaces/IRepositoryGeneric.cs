using System.Threading.Tasks;

namespace GaleriaImagens.Repository.Interfaces
{
    public interface IRepositoryGeneric
    {
        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Remove<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();
    }
}