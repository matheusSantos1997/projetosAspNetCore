using System.Collections.Generic;
using System.Threading.Tasks;
using GaleriaImagens.Business.Models;
using GaleriaImagens.Repository.Pagination;
using Microsoft.AspNetCore.Http;

namespace GaleriaImagens.Application.Interfaces
{
    public interface IImagemService
    {
        Task<PageList<Imagem>> ListarTodasImagens(PageParams pageParams);

        Task<PageList<Imagem>> ListarImagensPorUsuarioId(long usuarioId, PageParams pageParams);

        Task<Imagem> PegarImagemId(long id);

        Task<Imagem> SaveImagem(Imagem imagem);

        Task<Imagem> UpdateImagem(long id, Imagem imagem);

        Task<bool> DeleteImagem(long id);

        Task<bool> SaveChanges();
    }
}