using crudDapperEfCore.DTOs.Cliente;
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
        Task<PageList<ClienteDTO>> ListarTodosClientes(PageParams pageParams);

        Task<ClienteDTO> ListarClientePorId(long id);

        Task<PageList<ClienteDTO>> ListarTodosClientesPorNome(string nome, PageParams pageParams);

        Task<CreateNewClienteDTO> AdicionarNovoCliente(CreateNewClienteDTO clienteDto);

        Task<UpdateClienteDTO> AtualizarCliente(long id, UpdateClienteDTO clienteDto);

        Task<bool> DeletarCliente(long id);
    }
}
