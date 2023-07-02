using Dapper;
using Postagens.Domain.Models;
using Postagens.Repository.Data;
using Postagens.Repository.Interfaces;
using Postagens.Repository.Repositories.DbQueries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postagens.Repository.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly IDbConnection _connection;

        public PostRepository()
        {
            _connection = DataAccess.GetConnection();    
        }

        public async Task<List<Post>> PegarTodosPosts()
        {
            try
            {
                List<Post> posts = new();

                string query = PostDbScript.SelectAllPosts();

                var result = await _connection.QueryAsync<Post, Imagem, Usuario, Post>(query,
                    map: (post, imagem, usuario) =>
                    {
                        if (posts.FirstOrDefault(p => p.Id == post.Id) == null)
                        {
                            post.Imagem = imagem;
                            post.Usuario = usuario;
                            posts.Add(post);
                        }
                        else
                        {
                            post = posts.FirstOrDefault(p => p.Id == post.Id);
                        }

                        return post;
                    });
                result = posts;

                return result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Post> ListarPostPorId(long id)
        {
            try
            {
                List<Post> posts = new();

                string query = PostDbScript.SelectPostById();

                var result = await _connection.QueryAsync<Post, Imagem, Usuario, Post>(query,
                    map: (post, imagem, usuario) =>
                    {
                        if (posts.FirstOrDefault(p => p.Id == post.Id) == null)
                        {
                            post.Imagem = imagem;
                            post.Usuario = usuario;
                            posts.Add(post);
                        }
                        else
                        {
                            post = posts.FirstOrDefault(p => p.Id == post.Id);
                        }

                        return post;
                    }, new { Id = id });

                return result.FirstOrDefault();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<List<Post>> FiltrarPostsPorTitulo(string titulo)
        {
            throw new NotImplementedException();
        }
    }
}
