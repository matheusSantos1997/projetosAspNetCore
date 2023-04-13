using System.Threading.Tasks;
using GaleriaImagens.Business.DTOS;
using GaleriaImagens.Business.Models;

namespace GaleriaImagens.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetUsuarioById(long id);

        Task<Usuario> GetUsuarioByEmail(string email);

        Task<Usuario> Autenticacao(UsuarioLoginDTO user);
    }
}