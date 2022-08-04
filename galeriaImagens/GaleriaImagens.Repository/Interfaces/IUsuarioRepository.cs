using System.Threading.Tasks;
using GaleriaImagens.Business.Models;
using GaleriaImagens.Business.ViewModels;

namespace GaleriaImagens.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetUsuarioById(long id);

        Task<Usuario> Autenticacao(UsuarioLogin user);
    }
}