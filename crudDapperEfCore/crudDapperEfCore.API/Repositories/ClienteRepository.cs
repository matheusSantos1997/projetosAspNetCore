using System.Data;
using crudDapperEfCore.API.Context;
using crudDapperEfCore.API.models;
using crudDapperEfCore.API.Pagination;
using crudDapperEfCore.API.Repositories.Interfaces;
using crudDapperEfCore.API.Repositories.SQL;
using Dapper;

namespace crudDapperEfCore.API.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IDbConnection _connection;

        public ClienteRepository()
        {
            _connection = DataContext.GetConnection();
        }

        public async Task<PageList<Cliente>> GetAllClientes(PageParams pageParams)
        {
            try
            {
                Dictionary<dynamic, Cliente> clientes = new();

                string query = ClienteDBScript.SelectAllClientes();

                var result = await _connection.QueryAsync<Cliente, Produto, Cliente>(
                    query,
                    (cliente, produto) =>
                    {
                        if (!clientes.TryGetValue(cliente.Id, out var currentCliente))
                        {
                            currentCliente = cliente;
                            currentCliente.Produtos = new List<Produto>();
                            clientes[cliente.Id] = currentCliente;
                        }

                        if(produto != null)
                        {
                            currentCliente.Produtos?.Add(produto);
                        }
                        
                        return currentCliente;
                    });

                return PageList<Cliente>.Create(clientes.Values, pageParams.PageNumber, pageParams.PageSize);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Cliente>> GetAllClientes()
        {
            try
            {
                Dictionary<dynamic, Cliente> clientes = new();

                string query = ClienteDBScript.SelectAllClientes();

                var result = await _connection.QueryAsync<Cliente, Produto, Cliente>(
                        query,
                        (cliente, produto) =>
                        {
                            if (!clientes.TryGetValue(cliente.Id, out var currentCliente))
                            {
                                currentCliente = cliente;
                                currentCliente.Produtos = new List<Produto>();
                                clientes[cliente.Id] = currentCliente;
                            }

                            if (produto != null)
                            {
                                currentCliente.Produtos?.Add(produto);
                            }

                        return currentCliente;
                    });

            result = clientes.Values;

            return result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Cliente> GetClienteById(long id)
        {
            try
            {
                Dictionary<dynamic, Cliente> clientes = new();

                var query = ClienteDBScript.SelectClientePeloId(id);

                foreach(KeyValuePair<string, object> item in query)
                {
                    var result = await _connection.QueryAsync<Cliente, Produto, Cliente>(item.Key, 
                    map: (cliente, produto) => 
                    {
                        if(!clientes.TryGetValue(cliente.Id, out var currentCliente))
                        {
                            currentCliente = cliente;
                            currentCliente.Produtos = new List<Produto>();
                            clientes[cliente.Id] = currentCliente;
                        }
                        if (produto != null)
                        {
                            currentCliente.Produtos?.Add(produto);
                        }

                        return currentCliente;
                    }, item.Value);

                    return result.FirstOrDefault()!;
                }

                return null!;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<PageList<Cliente>> GetClienteByNome(string nomeCliente, PageParams pageParams)
        {
            try
            {
                Dictionary<dynamic, Cliente> clientes = new();

                var query = ClienteDBScript.FiltrarClientePorNome(nomeCliente);

                foreach(KeyValuePair<string, object> item in query)
                {
                    var result = await _connection.QueryAsync<Cliente, Produto, Cliente>(item.Key,
                         map: (cliente, produto) =>
                         {
                            if(!clientes.TryGetValue(cliente.Id, out var currentCliente))
                            {
                               currentCliente = cliente;
                               currentCliente.Produtos = new List<Produto>();
                               clientes[cliente.Id] = currentCliente;
                            }

                            if(produto != null)
                            {
                               currentCliente.Produtos?.Add(produto);
                            }
                        
                        return currentCliente;
                   }, item.Value);

                   return PageList<Cliente>.Create(clientes.Values, pageParams.PageNumber, pageParams.pageSize);
                }

                return null!;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}