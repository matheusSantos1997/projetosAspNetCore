using System.Collections.Generic;
using System.Threading.Tasks;
using ProceduresStorage.API.Models;

namespace ProceduresStorage.API.Repositories
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> ListarTodos();

        Task<Produto> ListarPorId(int id);

        void Add(Produto produto);

        void Update(Produto produto);

        void Delete(Produto produto);

        Task<bool> SaveChangesAsync();
    }
}