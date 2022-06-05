using System;
using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using uploadApi.Interfaces;
using uploadApi.Models;

namespace uploadApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UploadController : ControllerBase
    {
        private readonly IUploadRepository _uploadRepository;

        public UploadController(IUploadRepository uploadRepository)
        {
            _uploadRepository = uploadRepository;
        }

        [HttpPost]
        public IActionResult post(Arquivos file)
        {
            try
            {
                _uploadRepository.Add(file);

                if(_uploadRepository.SaveChanges())
                {
                    return Created($"/api/upload/{file.Id}", file);
                }

                return BadRequest(new 
                {
                     message = $"error insert new data."
                });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpPost("uploadFile")]
        public IActionResult uploadFile(IFormFile file = null) 
        {
            try
            {
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

                   if(extension == ".png" || extension == ".jpg") 
                   {
                      // salva o arquivo
                      using (var stream = new FileStream(fullPath, FileMode.Create))
                      {
                          file.CopyTo(stream); // realiza uma copia para o stream
                      }
                   } 
                   else 
                   {
                       return BadRequest(new 
                       {
                           message = $"only png or jpg."
                       });
                   }    
            }

            return Ok(new 
            {
                message = $"upload was successful."
            });
            }
            catch(IOException ex) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
            
            
        }
    }
}