using authenticationUsers.Application;
using authenticationUsers.Application.Interfaces;
using AuthenticationUsers.Business.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI;

namespace AuthenticationUsers.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IUserService _userService;

        public UsersController(IConfiguration config, IUserService userService)
        {
            _config = config;
            _userService = userService;
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetById(long id)
        {
            try
            {
                var user = await _userService.GetUserById(id);

                if(user == null)
                {
                    return NotFound("Not Found User.");
                }

                return Ok(user);
            }
            catch(Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"error when retrieving users. Error: {ex.Message}");
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Post(User model)
        {
            try
            {
                var user = await _userService.SignUp(model);

                if(user == null)
                {
                    return BadRequest("Error at add posts.");
                }

                return Ok(user);
            }
            catch(Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"error when retrieving users. Error: {ex.Message}");
            }
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody]User model)
        {
            try
            {
                var user = await _userService.SignIn(model);

                if(user == null)
                {
                    return NotFound(new { message = "Invalid Email or Password!" });
                }

                var token = TokenService.GenerateToken(user, _config);
                user.Password = "";
                var obj = new
                {
                    user = user,
                    token = token,
                };

                return Ok(obj);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"error when retrieving users. Error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Put(long id, User model)
        {
            try
            {
                var post = await _userService.UpdateUser(id, model);

                if (User == null) return BadRequest("Error at update users or posts.");

                return Ok(post);
            }
            catch(Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"error when retrieving users. Error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        // authenticated
        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => "Autenticado!"; // pega o nome do usuario autenticado

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee, admin")]
        public string Employee() => "Funcionário!";

        [HttpGet]
        [Route("admin")]
        [Authorize(Roles = "admin")]
        public string Manager() => "admin";
    }
}
