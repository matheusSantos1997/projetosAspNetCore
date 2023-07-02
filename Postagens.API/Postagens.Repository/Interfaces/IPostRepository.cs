using Postagens.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postagens.Repository.Interfaces
{
    public interface IPostRepository
    {
        Task<List<Post>> PegarTodosPosts();

        Task<List<Post>> FiltrarPostsPorTitulo(string titulo);

        Task<Post> ListarPostPorId(long id);
    }
}
