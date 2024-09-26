using crudDapperEfCore.API.models;
using crudDapperEfCore.API.Pagination;

namespace crudDapperEfCore.API.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        public Task<PageList<Cliente>> GetAllClientes(PageParams pageParams);

        public Task<List<Cliente>> GetAllClientes();

        public Task<Cliente> GetClienteById(long id);

        public Task<PageList<Cliente>> GetClienteByNome(string nomeCliente, PageParams pageParams);
    }
}