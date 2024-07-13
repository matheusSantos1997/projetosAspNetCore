using crudDapperEfCore.DTOs.Cliente;
using crudDapperEfCore.DTOs.Produto;
using crudDapperEfCore.Interfaces;
using crudDapperEfCore.Models;
using crudDapperEfCore.Pagination;
using Microsoft.EntityFrameworkCore;
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

        public async Task<PageList<ClienteDTO>> ListarTodosClientes(PageParams pageParams)
        {
            try
            {
                var clientes = await _clienteRepository.GetAllClientes(pageParams);

                if (clientes == null) return null;

                var clientesDto = new List<ClienteDTO>();

                // Mapeia cada cliente para o DTO correspondente
                foreach (var cliente in clientes)
                {
                    // Mapeia manualmente os Produtos para ProdutoDTO
                    var produtosDto = cliente.Produtos.Select(produto => new ProdutoDTO
                    {
                        Id = produto.Id,
                        NomeProduto = produto.NomeProduto,
                        TipoProduto = produto.TipoProduto,
                        Preco = produto.Preco,
                        ClienteId = produto.ClienteId

                        // Adicione outras propriedades conforme necessário
                    }).ToList();

                    var clienteDto = new ClienteDTO()
                    {
                        Id = cliente.Id,
                        NomeCliente = cliente.NomeCliente,
                        Email = cliente.Email,
                        Endereco = cliente.Endereco,
                        Produtos = produtosDto
                    };

                    clientesDto.Add(clienteDto);
                }

                // Cria um PageList para retornar os DTOs
                var pageListDto = new PageList<ClienteDTO>(clientesDto, clientes.TotalCount, clientes.CurrentPage, clientes.PageSize);

                return pageListDto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ClienteDTO> ListarClientePorId(long id)
        {
            try
            {
                var cliente = await _clienteRepository.GetClienteById(id);

                if (cliente == null) return null;

                // Mapeia manualmente os Produtos para ProdutoDTO
                var produtosDto = cliente.Produtos.Select(produto => new ProdutoDTO
                {
                    Id = produto.Id,
                    NomeProduto = produto.NomeProduto,
                    TipoProduto = produto.TipoProduto,
                    Preco = produto.Preco,
                    ClienteId = produto.ClienteId

                    // Adicione outras propriedades conforme necessário
                }).ToList();

                var clienteDto = new ClienteDTO()
                {
                    Id = cliente.Id,
                    NomeCliente = cliente.NomeCliente,
                    Email = cliente.Email,
                    Endereco = cliente.Endereco,
                    Produtos = produtosDto
                };

                return clienteDto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<PageList<ClienteDTO>> ListarTodosClientesPorNome(string nome, PageParams pageParams)
        {
            try
            {
                var clientes = await _clienteRepository.GetClienteByNome(nome, pageParams);

                if (clientes == null) return null;

                var clientesDto = new List<ClienteDTO>();

                foreach (var cliente in clientes)
                {
                    // Mapeia manualmente os Produtos para ProdutoDTO
                    var produtosDto = cliente.Produtos.Select(produto => new ProdutoDTO
                    {
                        Id = produto.Id,
                        NomeProduto = produto.NomeProduto,
                        TipoProduto = produto.TipoProduto,
                        Preco = produto.Preco,
                        ClienteId = produto.ClienteId

                        // Adicione outras propriedades conforme necessário
                    }).ToList();

                    var clienteDto = new ClienteDTO()
                    {
                        Id = cliente.Id,
                        NomeCliente = cliente.NomeCliente,
                        Email = cliente.Email,
                        Endereco = cliente.Endereco,
                        Produtos = produtosDto
                    };

                    clientesDto.Add(clienteDto);
                }

                // Cria um PageList para retornar os DTOs
                var pageListDto = new PageList<ClienteDTO>(clientesDto, clientes.TotalCount, clientes.CurrentPage, clientes.PageSize);

                return pageListDto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CreateNewClienteDTO> AdicionarNovoCliente(CreateNewClienteDTO clienteDto)
        {
            try
            {
                Cliente cliente = new()
                {
                    NomeCliente = clienteDto.NomeCliente,
                    Email = clienteDto.Email,
                    Endereco = clienteDto.Endereco,
                    Produtos = clienteDto.Produtos.Select(produtoDto => new Produto
                    {
                        NomeProduto = produtoDto.NomeProduto,
                        TipoProduto = produtoDto.TipoProduto,
                        Preco = produtoDto.Preco
                    }).ToList()
                };

                _genericRepository.Adicionar(cliente);

                bool save = await _genericRepository.CommitAsync();

                var clienteEntity = await _clienteRepository.GetClienteById(cliente.Id);

                CreateNewClienteDTO resultClienteDto = new()
                {
                    NomeCliente = clienteEntity.NomeCliente,
                    Email = clienteEntity.Email,
                    Endereco = clienteEntity.Endereco,
                    Produtos = clienteEntity.Produtos.Select(produtoDto => new CreateNewProdutoDTO
                    {
                        NomeProduto = produtoDto.NomeProduto,
                        TipoProduto = produtoDto.TipoProduto,
                        Preco = produtoDto.Preco
                    }).ToList()
                };

                if (save)
                {
                    return resultClienteDto;
                }

                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<UpdateClienteDTO> AtualizarCliente(long id, UpdateClienteDTO clienteDto)
        {
            try
            {
                // Usar Dapper para recuperar o cliente existente e seus produtos
                var clienteExistente = await _clienteRepository.GetClienteById(id);

                if (clienteExistente == null) return null;

                var cliente = new Cliente
                {
                    Id = clienteDto.Id,
                    NomeCliente = clienteDto.NomeCliente,
                    Email = clienteDto.Email,
                    Endereco = clienteDto.Endereco,
                    Produtos = clienteDto.Produtos.Select(p => new Produto
                    {
                        Id = p.Id,
                        NomeProduto = p.NomeProduto,
                        TipoProduto = p.TipoProduto,
                        Preco = p.Preco,
                        ClienteId = p.ClienteId
                    }).ToList()
                };

                // Atualiza as propriedades do cliente existente com os dados do cliente atualizado
                clienteExistente.NomeCliente = cliente.NomeCliente;
                clienteExistente.Email = cliente.Email;
                clienteExistente.Endereco = cliente.Endereco;

                // Recupera os produtos existentes
                var produtosExistentes = clienteExistente.Produtos.ToList();

                // Exclui produtos que não estão na nova lista
                foreach (var produtoExistente in produtosExistentes)
                {
                    if (!cliente.Produtos.Any(p => p.Id == produtoExistente.Id))
                    {
                        _genericRepository.Excluir(produtoExistente);
                    }
                }

                // Atualiza ou adiciona novos produtos
                foreach (var produtoAtualizado in cliente.Produtos)
                {
                    var produtoExistente = produtosExistentes.FirstOrDefault(p => p.Id == produtoAtualizado.Id);

                    if (produtoExistente != null)
                    {
                        // Atualiza o produto existente
                        produtoExistente.NomeProduto = produtoAtualizado.NomeProduto;
                        produtoExistente.Preco = produtoAtualizado.Preco;
                        // Atualize outras propriedades conforme necessário

                        // Marca o produto existente como modificado
                        _genericRepository.Attach(produtoExistente, EntityState.Modified);
                    }
                    else
                    {
                        // Adiciona o novo produto
                        produtoAtualizado.ClienteId = cliente.Id;
                        _genericRepository.Adicionar(produtoAtualizado);
                    }
                }

                // Marca o cliente existente como modificado
                //_genericRepository.Attach(clienteExistente, EntityState.Modified);
                _genericRepository.Atualizar(clienteExistente);

                bool save = await _genericRepository.CommitAsync();

                var clienteEntity = await _clienteRepository.GetClienteById(cliente.Id);

                // mapeamento de retorno da entidade cliente para updateClienteDTO
                UpdateClienteDTO resultClienteDto = new()
                {
                    Id = clienteEntity.Id,
                    NomeCliente = clienteEntity.NomeCliente,
                    Email = clienteEntity.Email,
                    Endereco = clienteEntity.Endereco,
                    Produtos = clienteEntity.Produtos.Select(produtoDto => new UpdateProdutoDTO
                    {
                        Id = produtoDto.Id,
                        NomeProduto = produtoDto.NomeProduto,
                        TipoProduto = produtoDto.TipoProduto,
                        Preco = produtoDto.Preco,
                        ClienteId = produtoDto.ClienteId
                    }).ToList()
                };

                if (save)
                {
                    // Usa Dapper para recuperar o cliente atualizado
                    return resultClienteDto;
                }

                return null;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new DbUpdateConcurrencyException(ex.Message);
            }
        }

        public async Task<bool> DeletarCliente(long id)
        {
            try
            {
                var cliente = await _clienteRepository.GetClienteById(id);

                if (cliente == null) return false;

                _genericRepository.Excluir(cliente);

                await _genericRepository.CommitAsync();

                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
