using System.Collections.Generic;
using System.Threading.Tasks;
using ProceduresStorage.API.Models;

namespace ProceduresStorage.API.Services
{
    public interface IProdutoService
    {
         Task<Produto> AddProduto(Produto model);

        Task<Produto> UpdateProduto(int idProduto, Produto model);

        Task<bool> DeleteProduto(int idProduto);

        //Eventos

        Task<List<Produto>> GetAllProdutos();

        Task<Produto> GetProdutoById(int idProduto);
    }
}