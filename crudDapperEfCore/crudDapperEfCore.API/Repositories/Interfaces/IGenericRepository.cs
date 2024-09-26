using Microsoft.EntityFrameworkCore;

namespace crudDapperEfCore.API.Repositories.Interfaces
{
    public interface IGenericRepository
    {
        void Adicionar<T>(T entity) where T : class;

        void Atualizar<T>(T entity) where T : class;

        void Attach<T>(T entity, EntityState state) where T : class;

        void Excluir<T>(T entity) where T : class;

        Task<bool> CommitAsync();
    }
}