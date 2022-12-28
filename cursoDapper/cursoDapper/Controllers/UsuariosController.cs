using cursoDapper.Interfaces;
using cursoDapper.Models;
using cursoDapper.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuariosController()
        {
            _repository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var usuarios = _repository.GetUsuarios();

            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var usuario = _repository.GetUsuario(id);

            if (usuario == null) return NotFound();

            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Insert([FromBody]Usuario usuario)
        {
            _repository.InsertUsuario(usuario);

            return Created($"/api/Usuarios/{usuario.Id}", usuario);
        }

        [HttpPut]
        public IActionResult Update([FromBody]Usuario usuario)
        {
            _repository.UpdateUsuario(usuario);
            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.DeleteUsuario(id);
            return Ok(new { message = $"Registro deletado com sucesso" });
        }

    }
}
