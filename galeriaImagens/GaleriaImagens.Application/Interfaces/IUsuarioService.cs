using System.Threading.Tasks;
using GaleriaImagens.Business.DTOS;
using GaleriaImagens.Business.Models;

namespace GaleriaImagens.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> SignUp(UsuarioDTO user);

        Task<Usuario> SignIn(UsuarioLoginDTO user);

        Task<Usuario> UpdateUser(long id, Usuario user);

        Task<Usuario> GetUserById(long id);

        Task<Usuario> GetByEmail(string email);
    }
}