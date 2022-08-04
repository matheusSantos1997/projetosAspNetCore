using System.Collections.Generic;
using System.Threading.Tasks;
using GaleriaImagens.Business.Models;
using Microsoft.AspNetCore.Http;

namespace GaleriaImagens.Application.Interfaces
{
    public interface IImagemService
    {
        Task<List<Imagem>> ListarTodasImagens();

        Task<List<Imagem>> ListarImagensPorUsuarioId(long usuarioId);

        Task<Imagem> PegarImagemId(long id);

        Task<Imagem> SaveImagem(Imagem imagem);

        Task<Imagem> UpdateImagem(long id, Imagem imagem);

        Task<bool> DeleteImagem(long id);

        Task<bool> SaveChanges();
    }
}