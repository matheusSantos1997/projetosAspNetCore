using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProceduresStorage.API.Models;
using ProceduresStorage.API.Repositories;

namespace ProceduresStorage.API.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<Produto> AddProduto(Produto model)
        {
            try
            {
                _produtoRepository.Add(model);

                bool save = await _produtoRepository.SaveChangesAsync();

                if(save) 
                {
                    return model;
                }

                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteProduto(int idProduto)
        {
            try
            {
               var produto = await _produtoRepository.ListarPorId(idProduto);

               if(produto == null) 
               {
                  throw new Exception("Produto nao encontrado.");
               }

               _produtoRepository.Delete(produto);

               return await _produtoRepository.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Produto>> GetAllProdutos()
        {
            try
            {
                var produtos = await _produtoRepository.ListarTodos();

                if(produtos == null)
                {
                    return null;
                }

                return produtos;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Produto> GetProdutoById(int idProduto)
        {
            try
            {
                var produto = await _produtoRepository.ListarPorId(idProduto);

                if(produto == null)
                {
                    return null;
                }

                return produto;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Produto> UpdateProduto(int idProduto, Produto model)
        {
            try
            {
                var produto = await _produtoRepository.ListarPorId(idProduto);
                model.Id = produto.Id;

                if(produto == null)
                {
                    return null;
                }

                _produtoRepository.Update(model);

                bool save = await _produtoRepository.SaveChangesAsync();

                if(save)
                {
                    return await _produtoRepository.ListarPorId(model.Id);
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