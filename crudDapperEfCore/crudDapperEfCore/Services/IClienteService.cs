using crudDapperEfCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.Services
{
    public interface IClienteService
    {
        Task<List<Cliente>> ListarTodosClientes();

        Task<Cliente> ListarClientePorId(long id);

        Task<List<Cliente>> ListarTodosClientesPorNome(string nome);

        Task<Cliente> AdicionarNovoCliente(Cliente cliente);

        Task<Cliente> AtualizarCliente(long id, Cliente cliente);

        Task<bool> DeletarCliente(long id);
    }
}
