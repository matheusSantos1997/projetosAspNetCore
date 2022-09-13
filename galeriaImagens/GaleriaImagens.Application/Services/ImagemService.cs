using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GaleriaImagens.Application.Interfaces;
using GaleriaImagens.Business.Models;
using GaleriaImagens.Repository.Interfaces;
using GaleriaImagens.Repository.Pagination;

namespace GaleriaImagens.Application.Services
{
    public class ImagemService : IImagemService
    {
        
        private readonly IRepositoryGeneric _repositoryGeneric;

        private readonly IImagemRepository _repositoryImagem;

        public ImagemService(IRepositoryGeneric repositoryGeneric, 
                             IImagemRepository repositoryImagem)
        {
            _repositoryGeneric = repositoryGeneric;
            _repositoryImagem = repositoryImagem;
        }

        public async Task<PageList<Imagem>> ListarTodasImagens(PageParams pageParams)
        {
            try
            {
                var imagens = await _repositoryImagem.GetAllImagens(pageParams);

                if(imagens == null) return null;

                return imagens;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<PageList<Imagem>> ListarImagensPorUsuarioId(long usuarioId, PageParams pageParams)
        {
            try
            {
                var imagens = await _repositoryImagem.GetImagensUsuarioId(usuarioId, pageParams);

                if(imagens == null) return null;

                return imagens;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Imagem> PegarImagemId(long id)
        {
            try
            {
                var imagem = await _repositoryImagem.GetImagemById(id);

                if(imagem == null) return null;

                return imagem;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> SaveChanges()
        {
            try
            { 
                return await _repositoryGeneric.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public async Task<Imagem> SaveImagem(Imagem imagem)
        {
            try
            {
                _repositoryGeneric.Add(imagem);
            
                if(await _repositoryGeneric.SaveChangesAsync())
                {
                   return imagem;
                } 

                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Imagem> UpdateImagem(long id, Imagem imagem)
        {
             try
             {
                 var img = await _repositoryImagem.GetImagemById(id);
                 imagem.Id = img.Id;

                 if(img == null) return null;

                 _repositoryGeneric.Update(imagem);

                 bool saved = await _repositoryGeneric.SaveChangesAsync();

                 if(saved) 
                 {
                    return imagem;
                 }

                 return null;  
             }
             catch(Exception ex)
             {
                 throw new Exception(ex.Message);
             }
        }

        public async Task<bool> DeleteImagem(long id)
        {
            try
            {
               var imagem = await _repositoryImagem.GetImagemById(id);

               if(imagem == null)
               {
                   return false;
               } 
               
               _repositoryGeneric.Remove(imagem);

               return await _repositoryGeneric.SaveChangesAsync();
               
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}