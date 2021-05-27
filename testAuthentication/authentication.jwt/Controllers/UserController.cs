using System;
using System.Threading.Tasks;
using authentication.jwt.models;
using authentication.jwt.services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace authentication.jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IConfiguration _config;
        private readonly IUserService _userService;
        public UserController(IUserService userService, IConfiguration config)
        {
            _userService = userService;
            _config = config;

        }
        
        // lists all registered users 
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try 
            {
               var resultsUsers = await _userService.GetAllUserAsync(true);
               return Ok(resultsUsers);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // register a new User
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Signup(User user)
        {
             try
             {
                  user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                 _userService.Add(user);

                 if(await _userService.saveChangesAsync())
                 {
                    return Created($"/api/user/{user.Id}", user);
                 }
             }
             catch (Exception ex)
             {
                 return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou! {ex.Message}");
             }
             return BadRequest();
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult<dynamic> Signin([FromBody]User model)
        {
             var user = _userService.Login(model);

             if (user == null) 
             {
                 return NotFound(new { message = "Usuário ou senha inválidos!"});
             }

             var token = TokenService.GenerateToken(user, _config);
             user.Password = "";
             return new {
                 user = user,
                 token = token,
                 config = _config
             };
            
            // return Ok();
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name); // pega o nome do usuario autenticado

        [HttpGet]   
        [Route("empployee")]
        [Authorize(Roles = "employee, manager")]
        public string Employee() => "Funcionário!";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Gerente";
    }
}