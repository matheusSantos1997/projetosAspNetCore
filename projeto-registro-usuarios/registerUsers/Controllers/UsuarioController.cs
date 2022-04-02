using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using registerUsers.Models;
using registerUsers.Services;

namespace registerUsers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var users = await _usuarioService.GetAllUsers();

                if(users == null) return NotFound();

                return Ok(users);
            }
            catch (Exception ex)
            {
                 return StatusCode(StatusCodes.Status500InternalServerError, $"Error in server {ex.Message}");
            }
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        { 
            try
            {
                var user = await _usuarioService.GetUserById(id);

                if(user == null) return NotFound();

                return Ok(user);
            }
            catch (Exception ex)
            {
                 return StatusCode(StatusCodes.Status500InternalServerError, $"Error in server {ex.Message}");
            }
        }

        [HttpGet("GetByName/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            try
            {
                 var users = await _usuarioService.GetUserByName(name);

                 if(users == null) return NotFound();

                 return Ok(users);
            }
            catch (Exception ex)
            {
                 return StatusCode(StatusCodes.Status500InternalServerError, $"Error in server {ex.Message}");
            }   
        }

        [HttpPost]
        public async Task<IActionResult> Post(Usuario model)
        {
            try
            {
                var user = await _usuarioService.InsertUser(model);

                if(user == null) return BadRequest("Error at add User.");

                return Created($"/api/usuario/{model.IdUsuario}", user);
                // return StatusCode(201, new { mensagem = $"INSERIDO COM SUCESSO" });
                // return Created($"/api/usuario/{model.Id}", new { mensagem = $"INSERIDO COM SUCESSO" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error in server {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Usuario model)
        {
            try
            {
                var user = await _usuarioService.UpdateUser(id, model);

                if(user == null) 
                {
                    return BadRequest("Error at update user.");
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error in server {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var user = await _usuarioService.DeleteUser(id);

                if(user)
                {
                    return Ok(new { message = "User Deleted"}); 
                }
                else
                {
                    return BadRequest("User is not deleted.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error in server {ex.Message}");
            }
        }
    }
}