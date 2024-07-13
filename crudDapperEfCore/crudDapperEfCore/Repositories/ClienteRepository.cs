using crudDapperEfCore.DBConnections;
using crudDapperEfCore.Interfaces;
using crudDapperEfCore.Models;
using crudDapperEfCore.Pagination;
using crudDapperEfCore.Repositories.DbScripts;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IDbConnection _connection;

        public ClienteRepository()
        {
            _connection = DataContext.GetConnetion();
        }

        public async Task<PageList<Cliente>> GetAllClientes(PageParams pageParams)
        {
            try
            {
                Dictionary<dynamic, Cliente> clientes = new();

                string query = ClienteQueriesString.SelectAllClientes();

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
                            currentCliente.Produtos.Add(produto);
                        }
                        
                        return currentCliente;
                    });

                return PageList<Cliente>.Create(clientes.Values, pageParams.PageNumber, pageParams.PageSize);
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

                var query = ClienteQueriesString.SelectClientePeloId(id);

                foreach(KeyValuePair<string, object> item in query)
                {
                    var result = await _connection.QueryAsync<Cliente, Produto, Cliente>(item.Key,
                     map: (cliente, produto) =>
                    {
                        if (!clientes.TryGetValue(cliente.Id, out var currentCliente))
                        {
                            currentCliente = cliente;
                            currentCliente.Produtos = new List<Produto>();
                            clientes[cliente.Id] = currentCliente;
                        }
                        if (produto != null)
                        {
                            currentCliente.Produtos.Add(produto);
                        }

                        return currentCliente;
                    },
                     item.Value);

                    return result.FirstOrDefault();
                }

                return null;               
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

                var query = ClienteQueriesString.FiltrarClientePorNome(nomeCliente);

                foreach(KeyValuePair<string, object> item in query)
                {
                    var result = await _connection.QueryAsync<Cliente, Produto, Cliente>(item.Key,
                   map: (cliente, produto) =>
                   {
                       if (!clientes.TryGetValue(cliente.Id, out var currentCliente))
                       {
                           currentCliente = cliente;
                           currentCliente.Produtos = new List<Produto>();
                           clientes[cliente.Id] = currentCliente;
                       }
                       if (produto != null)
                       {
                           currentCliente.Produtos.Add(produto);
                       }

                       return currentCliente;
                   }, item.Value);

                    return PageList<Cliente>.Create(clientes.Values, pageParams.PageNumber, pageParams.pageSize);
                }

                return null;          
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
