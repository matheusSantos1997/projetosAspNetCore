using System.Threading.Tasks;
using GaleriaImagens.Business.Models;
using GaleriaImagens.Business.ViewModels;

namespace GaleriaImagens.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> SignUp(Usuario user);

        Task<Usuario> SignIn(UsuarioLogin user);

        Task<Usuario> UpdateUser(long id, Usuario user);

        Task<Usuario> GetUserById(long id);
    }
}