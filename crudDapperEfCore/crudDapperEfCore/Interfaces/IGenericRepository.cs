using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.Interfaces
{
    public interface IGenericRepository
    {
        void Adicionar<T>(T entity) where T : class;

        void Atualizar<T>(T entity) where T : class;

        void Excluir<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();
    }
}
