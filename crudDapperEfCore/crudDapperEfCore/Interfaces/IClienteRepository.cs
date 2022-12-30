using crudDapperEfCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.Interfaces
{
    public interface IClienteRepository
    {
        public Task<List<Cliente>> GetAllClientes();

        public Task<Cliente> GetClienteById(long id);

        public Task<List<Cliente>> GetClienteByNome(string nome);    
    }
}
