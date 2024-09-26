using crudDapperEfCore.API.DTOs.Cliente;
using crudDapperEfCore.API.Pagination;

namespace crudDapperEfCore.API.Services.Interfaces
{
    public interface IClienteService
    {
        Task<PageList<ClienteDTO>> ListarTodosClientes(PageParams pageParams);

        Task<List<ClienteDTO>> ListarTodosClientes();

        Task<ClienteDTO> ListarClientePorId(long id);

        Task<PageList<ClienteDTO>> ListarTodosClientesPorNome(string nome, PageParams pageParams);

        Task<CreateNewClienteDTO> AdicionarNovoCliente(CreateNewClienteDTO clienteDto);

        Task<UpdateClienteDTO> AtualizarCliente(long id, UpdateClienteDTO clienteDto);

        Task<bool> DeletarCliente(long id);
    }
}