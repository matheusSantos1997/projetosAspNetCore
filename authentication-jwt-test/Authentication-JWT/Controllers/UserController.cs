using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Authentication_JWT.Models;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using Authentication_JWT.services;
using Authentication_JWT.Repositories;

namespace Authentication_JWT.Controllers
{
    [Route("v1/account")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult<dynamic> Authenticate([FromBody]User model)
        {
            var user = UserRepository.Get(model.Username, model.Password);

            if (user == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos!"});
            }

            var token = TokenService.GenerateToken(user);
            user.Password = "";
            return new {
                user = user,
                token = token
            };
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