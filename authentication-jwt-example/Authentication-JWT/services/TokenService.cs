using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Authentication_JWT.Models;
using Microsoft.IdentityModel.Tokens;

namespace Authentication_JWT.services
{
    public static class TokenService
    {
        public static string GenerateToken(User user) // funçao que gera o token
        {
             var tokenHandler = new JwtSecurityTokenHandler();
             var key = Encoding.ASCII.GetBytes(Settings.Secret); // gerando a chave
             
             // gerando um token descriptor com as informaçoes
             var tokenDescriptor = new SecurityTokenDescriptor
             {
                 Subject = new ClaimsIdentity(new Claim[]
                 {
                     new Claim(ClaimTypes.Name, user.Username.ToString()),
                     new Claim(ClaimTypes.Role, user.Role.ToString())
                 }),
                 
                 // tempo de expiraçao do token
                 Expires = DateTime.UtcNow.AddHours(2),
                 
                 // primeiro parametro = chave que vai ser encriptada e o segundo parametro é o tipo de encriptaçao
                 SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                         SecurityAlgorithms.HmacSha256Signature)
             };

             
             // criando o token
             var token = tokenHandler.CreateToken(tokenDescriptor);
             return tokenHandler.WriteToken(token);
        }
    }
}