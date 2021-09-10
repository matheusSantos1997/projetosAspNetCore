using ControleFinanceiro.API.Services;
using ControleFinanceiro.API.ViewModels;
using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuariosController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        // pegar pelo id
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(string id)
        {
            var usuario = await _usuarioRepositorio.PegarPeloId(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        // upload de foto
        [HttpPost("SalvarFoto")]
        public async Task<IActionResult> SalvarFoto()
        {
            // pega uma foto do formulario na requisiçao
            var foto = Request.Form.Files[0];
                
            byte[] b; // array de bytes
            
            // lê um arquivo que foi feito no upload
            using(var openReadStream = foto.OpenReadStream())
            {
                // copia o arquivo para memoria e transforma em bytes
                using (var memoryStream = new MemoryStream())
                {
                    await openReadStream.CopyToAsync(memoryStream);
                    b = memoryStream.ToArray(); // transforma o arquivo de bytes em array e copia para array de bytes
                }
            }

            return Ok(new
            {
                foto = b
            });
        }

        // registrar usuario
        [HttpPost("RegistrarUsuario")]
        public async Task<IActionResult> RegistrarUsuario(RegistroViewModel model)
        {
            // verifica se os dados sao validos
            if (ModelState.IsValid)
            {
                // status de criaçao do usuario
                IdentityResult usuarioCriado;
                string funcaoUsuario;

                Usuario usuario = new Usuario
                {
                    UserName = model.NomeUsuario,
                    Email = model.Email,
                    PasswordHash = model.Senha,
                    CPF = model.CPF,
                    Profissao = model.Profissao,
                    Foto = model.Foto
                };

                if(await _usuarioRepositorio.PegarQuantidadeUsuariosRegistrados() > 0)
                {
                    funcaoUsuario = "Usuario";
                }
                else
                {
                    funcaoUsuario = "Administrador";
                }

                usuarioCriado = await _usuarioRepositorio.CriarUsuario(usuario, model.Senha);

                if (usuarioCriado.Succeeded)
                {
                    await _usuarioRepositorio.IncluirUsuarioEmFuncao(usuario, funcaoUsuario);

                    var token = TokenService.GerarToken(usuario, funcaoUsuario);

                    await _usuarioRepositorio.LogarUsuario(usuario, false);

                    return Ok(new
                    {
                        emailUsuarioLogado = usuario.Email,
                        usuarioId = usuario.Id,
                        tokenUsuarioLogado = token
                    });
                }
                else
                {
                    return BadRequest(model);
                }
            }

            return BadRequest(model);
        }

        // login de usuario
        [HttpPost("LogarUsuario")]
        public async Task<IActionResult> LogarUsuario(LoginViewModel model)
        {
            if(model == null)
            {
                return NotFound("Usuário e / ou senhas inválidos");
            }

            Usuario usuario = await _usuarioRepositorio.PegarUsuarioPeloEmail(model.Email);

            // verificaçao se o usuario for diferente de null
            if(usuario != null)
            {
                PasswordHasher<Usuario> passwordHasher = new PasswordHasher<Usuario>();

                // a a senha encriptada existir e nao falhar
                if(passwordHasher.VerifyHashedPassword(usuario, usuario.PasswordHash, model.Senha) != PasswordVerificationResult.Failed)
                {
                    // pegando as funçoes do unsuario
                    var funcoesUsuario = await _usuarioRepositorio.PegarFuncoesUsuario(usuario);

                    var token = TokenService.GerarToken(usuario, funcoesUsuario.First());

                    await _usuarioRepositorio.LogarUsuario(usuario, false);

                    return Ok(new
                    {
                        emailUsuarioLogado = usuario.Email,
                        usuarioId = usuario.Id,
                        tokenUsuarioLogado = token
                    });
                }

                return NotFound("Usuário e/ou senha inválidos!");
            }

            return NotFound("Usuário e/ou senha inválidos!");
        } 
    }
}
