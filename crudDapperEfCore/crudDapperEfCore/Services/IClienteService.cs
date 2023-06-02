using crudDapperEfCore.Models;
using crudDapperEfCore.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.Services
{
    public interface IClienteService
    {
        Task<PageList<Cliente>> ListarTodosClientes(PageParams pageParams);

        Task<Cliente> ListarClientePorId(long id);

        Task<PageList<Cliente>> ListarTodosClientesPorNome(string nome, PageParams pageParams);

        Task<Cliente> AdicionarNovoCliente(Cliente cliente);

        Task<Cliente> AtualizarCliente(long id, Cliente cliente);

        Task<bool> DeletarCliente(long id);
    }
}
