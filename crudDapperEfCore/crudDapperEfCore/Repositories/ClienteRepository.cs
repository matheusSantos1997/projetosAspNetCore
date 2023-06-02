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
                List<Cliente> clientes = new();

                string query = ClienteQueriesString.SelectAllClientes();

                var result = await _connection.QueryAsync<Cliente, Produto, Cliente>(query,
                  map: (cliente, produto) =>
                  {
                      if (clientes.FirstOrDefault(u => u.Id == cliente.Id) == null)
                      {
                          cliente.Produtos = new List<Produto>();
                          clientes.Add(cliente);
                      }
                      else
                      {
                          cliente = clientes.FirstOrDefault(u => u.Id == cliente.Id);
                      }

                      cliente.Produtos.Add(produto);

                      return cliente;
                  });

                result = clientes;

                return PageList<Cliente>.Create(result, pageParams.PageNumber, pageParams.pageSize);
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
                List<Cliente> clientes = new();

                string query = ClienteQueriesString.SelectClientePeloId();

                var result = await _connection.QueryAsync<Cliente, Produto, Cliente>(query,
                    map: (cliente, produto) =>
                    {
                        if (clientes.FirstOrDefault(u => u.Id == cliente.Id) == null)
                        {
                            cliente.Produtos = new List<Produto>();
                            clientes.Add(cliente);
                        }
                        else
                        {
                            cliente = clientes.FirstOrDefault(u => u.Id == cliente.Id);
                        }

                        cliente.Produtos.Add(produto);

                        return cliente;
                    }, new { Id = id });

                return result.FirstOrDefault();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<PageList<Cliente>> GetClienteByNome(string nome, PageParams pageParams)
        {
            try
            {
                List<Cliente> clientes = new();

                string query = ClienteQueriesString.FiltrarClientePorNome();

                var result = await _connection.QueryAsync<Cliente, Produto, Cliente>(query,
                   map: (cliente, produto) =>
                   {
                       if (clientes.FirstOrDefault(u => u.Id == cliente.Id) == null)
                       {
                           cliente.Produtos = new List<Produto>();
                           clientes.Add(cliente);
                       }
                       else
                       {
                           cliente = clientes.FirstOrDefault(u => u.Id == cliente.Id);
                       }

                       cliente.Produtos.Add(produto);

                       return cliente;
                   }, new { NomeCliente = nome + "%" });

                result = clientes;

                return PageList<Cliente>.Create(result, pageParams.PageNumber, pageParams.pageSize);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
