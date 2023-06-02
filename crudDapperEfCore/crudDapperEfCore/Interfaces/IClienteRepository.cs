using crudDapperEfCore.Models;
using crudDapperEfCore.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.Interfaces
{
    public interface IClienteRepository
    {
        public Task<PageList<Cliente>> GetAllClientes(PageParams pageParams);

        public Task<Cliente> GetClienteById(long id);

        public Task<PageList<Cliente>> GetClienteByNome(string nome, PageParams pageParams);    
    }
}
