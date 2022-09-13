using System.Collections.Generic;
using System.Threading.Tasks;
using GaleriaImagens.Business.Models;
using GaleriaImagens.Repository.Pagination;

namespace GaleriaImagens.Repository.Interfaces
{
    public interface IImagemRepository
    {
        Task<PageList<Imagem>> GetAllImagens(PageParams pageParams);

        Task<PageList<Imagem>> GetImagensUsuarioId(long usuarioId, PageParams pageParams);

        Task<Imagem> GetImagemById(long id);
    }
}