using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ProAgil.API.Dtos;
using ProAgil.Domain.Identity;

namespace ProAgil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public UserController(IConfiguration config,
                              UserManager<User> userManager, // cria os usuarios
                              SignInManager<User> signInManager, // 
                              IMapper mapper // mapper
                             )
        {
            _config = config;
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        [HttpGet("GetUser")]
        [AllowAnonymous]
        public IActionResult GetUser()
        {
            // return Ok(userDto);
            return Ok(new UserDto());
        }

        [HttpPost("Register")]
        [AllowAnonymous] // vai fazer como que nao precise de autenticaçao para acessar a rota
        public async Task<IActionResult> Register(UserDto userDto) 
        {
            try 
            {
                var user = _mapper.Map<User>(userDto);
                var result = await _userManager.CreateAsync(user, userDto.Password);

                var userToReturn = _mapper.Map<UserDto>(user);
                
                // se o registro for cadastrado com sucesso na base de dados
                if (result.Succeeded)
                {
                    return Created("GetUser", userToReturn);
                }

                return BadRequest(result.Errors);
            } 
            catch(System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados Falhou! {ex.Message}");
            }
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserLoginDto userLogin)
        {
            try
            {
                // verifica se o usuario existe
                var user = await _userManager.FindByNameAsync(userLogin.UserName);

                /* faz um check na senha se ela está correta e o false para nao permitir 
                o bloqueio do usuario caso erre a senha varias vezes */
                var result = await _signInManager.CheckPasswordSignInAsync(user, userLogin.Password, false);

                if (result.Succeeded)
                {
                    var appUser = await _userManager.Users
                        .FirstOrDefaultAsync(u => u.NormalizedUserName == userLogin.UserName.ToUpper());
                    
                    var userToReturn = _mapper.Map<UserLoginDto>(appUser);
                    
                    // crianto um token de autenticaçao
                    return Ok(new {
                       token = GenerateJwToken(appUser).Result, // vai gerar o token baseado no usuário que foi encontrado
                       user = userToReturn
                    });
                }

                return Unauthorized(); // caso nao for autorizado
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados Falhou! {ex.Message}");
            }
        }
        
        // método para gerar o token
        private async Task<string> GenerateJwToken(User user)
        {
            // criando os papéis de cada usuário no sistema verificando as autorizaçoes do usuario
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName)
            };

            var roles = await _userManager.GetRolesAsync(user); // definindo o papel que o usuario possui
            
            // adiciona os papeis
            foreach (var role in roles) 
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }


            // chave que vai criptografar com a propriedade Token 
            var key = new SymmetricSecurityKey(Encoding.ASCII
                    .GetBytes(_config.GetSection("AppSettings:Token").Value));
            
            // gerando a criptografia
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature); // algoritmo de criptografia

            // montando token
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                 Subject = new ClaimsIdentity(claims),

                 // tempo que vai expirar o token de acesso
                 Expires = DateTime.Now.AddDays(1), // vai expirar em 1 dia
                 SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor); // cria o token

            return tokenHandler.WriteToken(token); // retorna o token

        }
    }
}