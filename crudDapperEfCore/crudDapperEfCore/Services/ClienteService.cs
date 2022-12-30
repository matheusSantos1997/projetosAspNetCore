using crudDapperEfCore.Interfaces;
using crudDapperEfCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IGenericRepository _genericRepository;

        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IGenericRepository genericRepository, IClienteRepository clienteRepository)
        {
            _genericRepository = genericRepository;
            _clienteRepository = clienteRepository;
        }

        public async Task<Cliente> AdicionarNovoCliente(Cliente cliente)
        {
            try
            {
                _genericRepository.Adicionar(cliente);

                bool save = await _genericRepository.SaveChangesAsync();

                if (save)
                {
                    return await _clienteRepository.GetClienteById(cliente.Id);
                }

                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Cliente> AtualizarCliente(long id, Cliente cliente)
        {
            try
            {
                var c = await _clienteRepository.GetClienteById(id);

                cliente.Id = c.Id;

                if (c == null) return null;

                _genericRepository.Atualizar(cliente);

                bool save = await _genericRepository.SaveChangesAsync();

                if (save)
                {
                    return await _clienteRepository.GetClienteById(cliente.Id);
                }

                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeletarCliente(long id)
        {
            try
            {
                var cliente = await _clienteRepository.GetClienteById(id);

                if (cliente == null) return false;

                _genericRepository.Excluir(cliente);

                return await _genericRepository.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Cliente> ListarClientePorId(long id)
        {
            try
            {
                var cliente = await _clienteRepository.GetClienteById(id);

                if (cliente == null) return null;

                return cliente;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Cliente>> ListarTodosClientes()
        {
            try
            {
                var clientes = await _clienteRepository.GetAllClientes();

                if (clientes == null) return null;

                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Cliente>> ListarTodosClientesPorNome(string nome)
        {
            try
            {
                var clientes = await _clienteRepository.GetClienteByNome(nome);

                if (clientes == null) return null;

                return clientes;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
