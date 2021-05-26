using System.Threading.Tasks;
using Gamer_info_webapi.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gamer_info_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class UserController : ControllerBase
    {
        private IGamerInfo _database;
        public UserController(IGamerInfo _database)
        {
            this._database = _database;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _database.GetAllUsuarioAsync(true);
                return Ok(results);
            }
            catch(System.Exception ex)
            {
                 return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou! {ex.Message}");
            }
        }
        
        [HttpGet("{IdUsuario}")]
        public async Task<IActionResult> Get(int IdUsuario)
        {
            try 
            {
                 var result = await _database.GetUsuarioAsyncById(IdUsuario, true);
                 return Ok(result);
            }
            catch(System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou! {ex.Message}");
            }
            
        }

        [HttpGet("getByNome/{nome}")]
        public async Task<IActionResult> Get(string nome)
        {
            try
            {
                var result = await _database.GetAllUsuarioAsyncByNome(nome, true);
                return Ok(result);
            }
            catch(System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou! {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Usuario model)
        {
            try
            {
                _database.Add(model);
                
                if(await _database.saveChangesAsync())
                {
                    return Created($"/api/user/{model.IdUsuario}", model);
                }
            }
            catch(System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou! {ex.Message}");
            }

            return BadRequest();
        }

        [HttpPut("{IdUsuario}")]
        public async Task<IActionResult> Put(int IdUsuario, Usuario model)
        {
            try
            {
                var usuario = await _database.GetUsuarioAsyncById(IdUsuario, false);

                if (usuario == null)
                {
                    return NotFound();
                }

                _database.Update(model);

                if(await _database.saveChangesAsync())
                {
                    return Created($"/api/user/{model.IdUsuario}", model);
                }
            }
            catch(System.Exception ex)
            {
                 return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou! {ex.Message}");
            }

            return BadRequest();
        }

        [HttpDelete("{IdUsuario}")]
        public async Task<IActionResult> Delete(int IdUsuario) 
        {
            try
            {
                var usuario = await _database.GetUsuarioAsyncById(IdUsuario, false);

                if (usuario == null)
                {
                    return NotFound();
                }

                _database.Delete(usuario);

                if (await _database.saveChangesAsync())
                {
                    return Ok();
                }
            }
            catch(System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou! {ex.Message}");
            }

            return BadRequest();
        }
    }
}