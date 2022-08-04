using System;
using System.Threading.Tasks;
using GaleriaImagens.Application.Interfaces;
using GaleriaImagens.Application.Services;
using GaleriaImagens.Business.Models;
using GaleriaImagens.Business.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GaleriaImagens.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IConfiguration _config;

        private readonly IUsuarioService _usuario;

        public UsuariosController(IConfiguration config, IUsuarioService usuario)
        {
            _config = config;
            _usuario = usuario;
        }

        [HttpGet("GetUsuarioById/{id}")]
        [Authorize]
        public async Task<IActionResult> GetUsuarioById(long id)
        {
            try
            {
                var usuario = await _usuario.GetUserById(id);

            if(usuario == null) return NotFound("Not Found User.");

            return Ok(usuario);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"error when retrieving users. Error: {ex.Message}");
            }
        }

        [HttpPost("CadastrarUsuario")]
        [AllowAnonymous]
        public async Task<IActionResult> CadastrarUsuario(Usuario user)
        {
            try
            {
                var usuario = await _usuario.SignUp(user);

                if(usuario == null) return BadRequest();

                return Created($"/api/usuarios/CadastrarUsuario/{user.Id}", usuario);
                // return Ok(usuario);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"error when retrieving users. Error: {ex.Message}");
            }
        }

        [HttpPost("LoginUsuario")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginUsuario([FromBody]UsuarioLogin user)
        {
            try
            {
                var usuario = await _usuario.SignIn(user);

                if(usuario == null)
                {
                    return NotFound(new { message = "Invalid Email or Password!"});
                }

                var token = TokenService.GenerateToken(usuario, _config);
                // usuario.Senha = "";
                var obj = new
                {
                    emailUsuarioLogado = usuario.Email,
                    usuarioId = usuario.Id,
                    token = token
                };

                return Ok(obj);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"error when retrieving users. Error: {ex.Message}");
            }
        }

        [HttpPut("AtualizarUsuario/{id}")]
        [Authorize]
        public async Task<IActionResult> AtualizarUsuario(long id, Usuario model)
        {
            try
            {
                var usuario = await _usuario.UpdateUser(id, model);

                if(usuario == null) return NotFound("Error at update users or posts.");

                return Ok(usuario);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"error when retrieving users. Error: {ex.Message}");
            }
        } 

        // authenticated
        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name); // pega o nome do usuario autenticado
    }
}