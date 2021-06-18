using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeOneToOne.interfaces;
using testeOneToOne.models;

namespace testeOneToOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOneController : ControllerBase
    {
        private readonly IGeneralUsers _contextGeneral;

        private readonly IUserOne _contextUserOne;

        public UserOneController(IGeneralUsers contextGeneral, IUserOne contextUserOne)
        {
            _contextGeneral = contextGeneral;
            _contextUserOne = contextUserOne;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                object users = await _contextUserOne.GetAllUsersOne(true);

                if (users == null) return NotFound("Users Not Found");

                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro trazer usuarios {ex.Message}");
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                object user = await _contextUserOne.GetUserOneById(id, true);

                if (user == null) return NotFound("user not found!");

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro trazer usuarios {ex.Message}");
            }
        }
        [HttpGet("getByName/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            try
            {
                object user = await _contextUserOne.GetAllUserOneByName(name, true);

                return Ok(user);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro trazer usuarios {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> insertUser(UserOne model)
        {
            try
            {
                _contextGeneral.AddUser(model);

                if (await _contextGeneral.SaveUser())
                {
                    return Created($"/api/userOne/{model.idUserOne}", model);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro trazer usuarios {ex.Message}");
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserOne model)
        {
            try
            {
                var user = await _contextUserOne.GetUserOneById(id, false);

                if (user == null)
                {
                    return NotFound();
                }

                _contextGeneral.UpdateUser(model);

                if (await _contextGeneral.SaveUser())
                {
                    return Created($"/api/userOne/{model.idUserOne}", model);
                }
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro trazer usuarios!{ex.Message}");
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                var user = await _contextUserOne.GetUserOneById(id, false);

                if (user == null)
                {
                    return NotFound("nenhum usuário encontrado para ser excluído");
                }

                _contextGeneral.DeleteUser(user);

                if(await _contextGeneral.SaveUser())
                {
                    return Ok("Deletado!");
                }
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro trazer usuarios!{ex.Message}");
            }

            return BadRequest();
        }

    }
}
