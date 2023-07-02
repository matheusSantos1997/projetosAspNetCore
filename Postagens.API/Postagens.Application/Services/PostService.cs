using Postagens.Application.Interfaces;
using Postagens.Domain.Dtos;
using Postagens.Domain.Models;
using Postagens.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postagens.Application.Services
{
    public class PostService : IPostService
    {
        private readonly IGenericRepository _genericRepository;

        private readonly IPostRepository _postRepository;

        public PostService(IGenericRepository genericRepository, IPostRepository postRepository)
        {
            _genericRepository = genericRepository;
            _postRepository = postRepository;
        }

        public async Task<Post> CadastrarNovoPost(PostCreateDTO postDto)
        {
            try
            {
                Post post = new()
                {
                    Titulo = postDto.Titulo,
                    Conteudo = postDto.Conteudo,
                    UsuarioId = postDto.UsuarioId,
                };

                _genericRepository.Adicionar(post);

                bool save = await _genericRepository.SaveChangesAsync();

                if (save)
                {
                    return await _postRepository.ListarPostPorId(post.Id);
                }

                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Post>> ListarTodosPosts()
        {
            try
            {
                var posts = await _postRepository.PegarTodosPosts();

                if (posts == null) return null;

                return posts;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Post> ListarPostPorId(long id)
        {
            try
            {
                var post = await _postRepository.ListarPostPorId(id);

                if(post == null) return null;

                return post;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
