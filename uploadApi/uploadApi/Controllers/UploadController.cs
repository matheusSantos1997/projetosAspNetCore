using System;
using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
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

        private readonly IWebHostEnvironment _hostEnvironment;

        public UploadController(IUploadRepository uploadRepository, IWebHostEnvironment hostEnvironment)
        {
            _uploadRepository = uploadRepository;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet("GetAllFiles")]
        public IActionResult get() 
        {
            var arquivos = _uploadRepository.GetAllArquivos();

            if(arquivos == null) return NotFound();

            return Ok(arquivos);
        }

        [HttpGet("GetFileById/{id}")]
        public IActionResult GetById(int id)
        {
            var arquivo = _uploadRepository.GetByIdArquivo(id);

            return (arquivo == null) ? NotFound() : Ok(arquivo);
        }

        [HttpPost("UploadFile")]
        public IActionResult uploadFile(IFormFile file = null) 
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

                      Arquivos arq = new Arquivos();
                      arq.Name = fileName;
                      arq.URLImagem = fullPath;
                      arq.SavedAt = DateTime.UtcNow;
                      

                      // salva o arquivo
                      using (var stream = new FileStream(fullPath, FileMode.Create))
                      {
                          file.CopyTo(stream); // realiza uma copia para o stream
                      }

                      _uploadRepository.Add(arq);
                      _uploadRepository.SaveChanges();
                   } 
                   else 
                   {
                       return BadRequest(new 
                       {
                           message = $"only jpeg, jpg or png."
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

        [HttpPut("UpdateFile/{id}")]
        public IActionResult UpdateFile(int id, IFormFile file = null)
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
                      var arquivo = _uploadRepository.GetByIdArquivo(id);

                      if(arquivo == null) return NotFound();

                      Arquivos arq = new Arquivos();
                      arq.Id = arquivo.Id;
                      arq.Name = fileName;
                      arq.URLImagem = fullPath;
                      arq.SavedAt = DateTime.UtcNow;

                      

                      // salva o arquivo
                      using (var stream = new FileStream(fullPath, FileMode.Create))
                      {
                         file.CopyTo(stream); // realiza uma copia para o stream
                      }

                     // Directory.Move()

                      _uploadRepository.Update(arq);
                      
                      
                      if(_uploadRepository.SaveChanges())
                      {
                         return Ok(new 
                         {
                            message = $"upload was successful."
                         });
                      }
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
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }

            return BadRequest();

             
        }

        [HttpDelete("DeleteFile/{id}")]
        public IActionResult DeleteFile(int id)
        {
            try
            {
                string imageName = "";
                var arquivo = _uploadRepository.GetByIdArquivo(id);
                imageName = arquivo.URLImagem;
 
                if(arquivo == null) return NotFound();
                
                var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, @"Images", imageName);

                if(System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                    _uploadRepository.Delete(arquivo);
                }    

                if(_uploadRepository.SaveChanges())
                {
                    return Ok(new 
                    {
                        message = $"image Deleted success"
                    });
                }
               
            }
            catch (IOException ex)
            {
                 return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }

            return BadRequest();
        }
    }
}