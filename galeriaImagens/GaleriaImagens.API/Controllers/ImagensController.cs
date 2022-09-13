using System;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GaleriaImagens.API.Extesions;
using GaleriaImagens.Application.Interfaces;
using GaleriaImagens.Business.Models;
using GaleriaImagens.Repository.Pagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GaleriaImagens.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ImagensController : ControllerBase
    {
        private readonly IImagemService _imagemService;

        private readonly IWebHostEnvironment _hostEnvironment;

        public ImagensController(IImagemService imagemService, IWebHostEnvironment hostEnvironment)
        {
            _imagemService = imagemService;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet("GetAllImagens")]
        public async Task<IActionResult> GetAllImagens([FromQuery]PageParams pageParams)
        {
            try
            {
                var imagens = await _imagemService.ListarTodasImagens(pageParams);

                if(imagens == null) return NotFound();

                Response.AddPagination(imagens.CurrentPage, imagens.PageSize, imagens.TotalCount, imagens.TotalPages);

                return Ok(imagens);
            }
            catch (IOException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                  $"Algo deu errado. Erro: {ex.Message}");
            }
        }
        
        [HttpGet("GetAllImagensByUsuarioId/{usuarioId}")]
        public async Task<IActionResult> GetAllImagensByUsuarioId(long usuarioId, [FromQuery] PageParams pageParams)
        {
            try
            {
                var imagens = await _imagemService.ListarImagensPorUsuarioId(usuarioId, pageParams);

                if(imagens == null) return NotFound();

                Response.AddPagination(imagens.CurrentPage, imagens.PageSize, imagens.TotalCount, imagens.TotalPages);

                return Ok(imagens);
            }
            catch(IOException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                  $"Algo deu errado. Erro: {ex.Message}");
            }
        }

        [HttpGet("GetImageById/{id}")]
        public async Task<IActionResult> GetImageById(long id)
        {
            try
            {
                var imagem = await _imagemService.PegarImagemId(id);

                if(imagem == null) return NotFound();

                return Ok(imagem);
            }
            catch (IOException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                  $"Algo deu errado. Erro: {ex.Message}");
            }
        } 

        [HttpPost("UploadImagem")]
        public async Task<IActionResult> UploadImagem(IFormFile file = null)
        {
            try
            {
                bool extensaoValida = false;

                string[] extensions = { ".jpeg", ".jpg", ".png" };

                file = Request.Form.Files[0];

                var folderName = Path.Combine("Images"); // pega o diretorio onde vai salvar

                string extension = Path.GetExtension(file.FileName);

                // combina o diretorio onde vai armazerar + diretorio da aplicaçao
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName); // salva no diretorio

                if(file.Length > 0)
                {
                   // vai pegar o nome do arquivo e montar o arquivo
                   var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName;

                   fileName = Guid.NewGuid().ToString() + extension;

                   // se vier aspas duplas ou espaçamentos no nome do arquivo, vai ser removido
                   var fullPath = Path.Combine(pathToSave, fileName.Replace("\"", " ").Trim());

                   foreach(string ex in extensions) 
                   {
                        if(extension == ex)
                        {
                            extensaoValida = true;
                        }
                   }

                   if(extensaoValida)
                   {
                      var usuarioId = User.Identity.IsAuthenticated;
                       
                      Imagem img = new Imagem();
                      img.Nome = fileName;
                      img.URLImagem = fullPath;
                      img.SavedAt = DateTime.UtcNow;
                      img.UsuarioId = Convert.ToInt64(usuarioId);

                      // salva o arquivo
                      using (var stream = new FileStream(fullPath, FileMode.Create))
                      {
                          await file.CopyToAsync(stream); // realiza uma copia para o stream
                      }

                     await _imagemService.SaveImagem(img);
                      
                   }
                   else
                   {
                    if(extension != extensions.Length.ToString()) 
                    {
                       return BadRequest(new 
                       {
                           menssagem = $"only jpeg, jpg or png."
                       });
                    }
                      
                   }
 
                }

                return Ok(new 
                {
                    message = $"upload was successful."
                });    
            }
            catch (IOException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                  $"Algo deu errado. Erro: {ex.Message}");
            }
        }

        [HttpPut("UpdateImagem/{id}")]
        public async Task<IActionResult> UpdateImagem(long id, IFormFile file = null)
        {
            try
            {
                if (file is null)
                {
                    throw new ArgumentNullException(nameof(file));
                }

                bool extensaoValida = false;

                string[] extensions = { ".jpeg", ".jpg", ".png" };

                file = Request.Form.Files[0];

                var folderName = Path.Combine("Images"); // pega o diretorio onde vai salvar
            
                string extension = Path.GetExtension(file.FileName);
            
               // combina o diretorio onde vai armazerar + diretorio da aplicaçao
               var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName); // salva no diretorio

               if(file.Length > 0)
               {
                   // vai pegar o nome do arquivo e montar o arquivo
                   var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName;

                   fileName = Guid.NewGuid().ToString() + extension;

                   // se vier aspas duplas ou espaçamentos no nome do arquivo, vai ser removido
                   var fullPath = Path.Combine(pathToSave, fileName.Replace("\"", " ").Trim());

                   foreach(string ex in extensions) 
                   {
                        if(extension == ex)
                        {
                            extensaoValida = true;
                        }
                   }

                   if(extensaoValida)
                   {
                       var usuarioId = User.Identity.IsAuthenticated;

                       var imagem = await _imagemService.PegarImagemId(id);

                       if(imagem == null) return NotFound();

                       Imagem img = new Imagem();
                       img.Nome = fileName;
                       img.URLImagem = fullPath;
                       img.SavedAt = DateTime.UtcNow;
                       img.UsuarioId = Convert.ToInt64(usuarioId);

                       // atualiza o caminho da imagem
                       Directory.Move(imagem.URLImagem, img.URLImagem);

                       // salva o arquivo
                       using (var stream = new FileStream(fullPath, FileMode.Create))
                       {
                           await file.CopyToAsync(stream);
                       }

                       await _imagemService.UpdateImagem(id, img);

                       
                        return Ok(new 
                        {
                            message = $"image was updated successful."
                        });
                   }
                   else
                   {
                       return BadRequest(new 
                       {
                           message = $"only jpeg, jpg or png."
                       });
                   }
               }
            }
            catch(IOException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                  $"Algo deu errado. Erro: {ex.Message}");
            }

            return BadRequest();
        }

        [HttpDelete("DeleteImagem/{id}")]
        public async Task<IActionResult> DeleteImagem(long id)
        {
            try
            {
               string imageName = "";
               var imagem = await _imagemService.PegarImagemId(id);
               imageName = imagem.URLImagem;

               if(imagem == null) return NotFound();

               var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, @"Images", imageName);

               if(System.IO.File.Exists(imagePath))
               {
                   System.IO.File.Delete(imagePath);
               }

               await _imagemService.DeleteImagem(imagem.Id);

               return Ok(new 
               {
                   message = $"image Deleted success"
               });
            }
            catch (IOException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                  $"Algo deu errado. Erro: {ex.Message}");
            }
        }
    }
}