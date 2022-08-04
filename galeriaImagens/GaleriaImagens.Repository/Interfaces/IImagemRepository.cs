using System.Collections.Generic;
using System.Threading.Tasks;
using GaleriaImagens.Business.Models;

namespace GaleriaImagens.Repository.Interfaces
{
    public interface IImagemRepository
    {
        Task<List<Imagem>> GetAllImagens();

        Task<List<Imagem>> GetImagensUsuarioId(long usuarioId);

        Task<Imagem> GetImagemById(long id);
    }
}