using CrudContatosMvc.Helper;
using CrudContatosMvc.Models;
using CrudContatosMvc.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CrudContatosMvc.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        private readonly ISessao _sessao;

        private readonly IEmail _email;

        public LoginController(IUsuarioRepository usuarioRepository, ISessao sessao, IEmail email)
        {
            _usuarioRepository = usuarioRepository;
            _sessao = sessao;
            _email = email;
        }

        public IActionResult Index()
        {
            // se o usuario estiver logado, redireciona para a controller de home
            if(_sessao.BuscarSessaoUsuario() !=  null) return RedirectToAction("Index", "Home");

            return View();
        }

        public IActionResult RedefinirSenha()
        {
            return View();
        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                   var usuario = _usuarioRepository.BuscarPorLogin(loginModel.Login);


                    if(usuario != null)
                    {
                        if(usuario.SenhaValida(loginModel.Senha))
                        {
                            _sessao.CriarSessaoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }

                        TempData["MensagemErro"] = $"Senha do usuário é inválida Por favor, tente novamente.";

                    }

                    TempData["MensagemErro"] = $"Usuário e/ou Senha inválido(s). Por favor, tente novamente.";

                }

                return View("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"ops, houve um erro ao tentar logar, tente novamente, detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult EnviarLinkRedefinirSenha(RedefinirSenhaModel redefinirSenhaModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = _usuarioRepository.BuscarPorEmailLogin(redefinirSenhaModel.Email, redefinirSenhaModel.Login);

                    if(usuario != null)
                    {
                        string novaSenha = usuario.GerarNovaSenha();

                        string mensagem = $"Sua nova senha é: {novaSenha}";

                        bool emailEnviado = _email.Enviar(usuario.Email, "Sistema Contatos - Nova Senha", mensagem);

                        if(emailEnviado)
                        {
                            _usuarioRepository.Atualizar(usuario);
                            TempData["MensagemSucesso"] = $"Enviamos para seu e-mail cadastrado uma nova senha.";
                        }
                        else
                        {
                            TempData["MensagemErro"] = $"Não conseguimos enviar email. Por favor, tente novamente.";
                        }

                        return RedirectToAction("Index", "Login");
                    }

                    TempData["MensagemErro"] = $"Não conseguimos redefinir sua senha. Por favor, verifique os dados informados.";

                }

                return View("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"ops, houve um erro ao tentar redefinir sua senha, tente novamente, detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
