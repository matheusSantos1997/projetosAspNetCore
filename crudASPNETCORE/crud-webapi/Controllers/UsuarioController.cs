using System.Threading.Tasks;
using crud_webapi.Domain;
using crud_webapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ICrudWebAPI _repository; // injetando a classe por meio da interface no repository

        public UsuarioController(ICrudWebAPI repository)
        {
            _repository = repository;
        }

        // retornando os usuarios
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _repository.GetAllUsuariosAsync(true);
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!");
            }
        }

        // cadastrando novos usuários
        [HttpPost]
        public async Task<IActionResult> Post(Usuario model)
        {
            try
            {
                _repository.Add(model);

                if (await _repository.SaveChangesAsync())
                {
                    return Created($"/api/usuario/{model.IdUsuario}", model);
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou!");
            }

            // caso não retorne nenhuma exceçao
            return BadRequest();
        }

        // atualizar usuários
        [HttpPut("{UsuarioId}")]
        public async Task<IActionResult> Put(int UsuarioId, Usuario model)
        {
            try
            {
                var usuario = await _repository.GetUsuarioAsyncById(UsuarioId, false);

                if (usuario == null)
                {
                    return NotFound(); // nao vai encontrar
                }

                _repository.Update(model);

                if (await _repository.SaveChangesAsync())
                {
                    return Created($"/api/usuario/{model.IdUsuario}", model);
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!");
            }

            return BadRequest();
        }

        // deletando usuarios
        [HttpDelete("{UsuarioId}")]
        public async Task<IActionResult> Delete(int UsuarioId)
        {
            try
            {
                var usuario = await _repository.GetUsuarioAsyncById(UsuarioId, false);

                if (usuario == null)
                {
                    return NotFound();
                }

                _repository.Delete(usuario);

                if (await _repository.SaveChangesAsync())
                {
                    return Ok();
                }
            }

            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou!");
            }

            return BadRequest();
        }
    }
}