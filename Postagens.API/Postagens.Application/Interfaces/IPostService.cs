using Postagens.Domain.Dtos;
using Postagens.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postagens.Application.Interfaces
{
    public interface IPostService
    {
        Task<List<Post>> ListarTodosPosts();

        Task<Post> ListarPostPorId(long id);

        Task<Post> CadastrarNovoPost(PostCreateDTO postDto);
    }
}
