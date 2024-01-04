using CrudContatosMvc.Helper;
using CrudContatosMvc.Models;
using CrudContatosMvc.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CrudContatosMvc.Controllers
{
    public class AlterarSenhaController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        private readonly ISessao _sessao;

        public AlterarSenhaController(IUsuarioRepository usuarioRepository, ISessao sessao)
        {
            _usuarioRepository = usuarioRepository;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Alterar(AlterarSenhaModel alterarSenhaModel)
        {
            try
            {
                var usuarioLogado = _sessao.BuscarSessaoUsuario();
                alterarSenhaModel.Id = usuarioLogado.Id;

                if (ModelState.IsValid)
                {
                    _usuarioRepository.AlterarSenha(alterarSenhaModel);

                    TempData["MensagemSucesso"] = "Senha Alterada com sucesso!";
                    return View("Index", alterarSenhaModel);
                }

                return View("Index", alterarSenhaModel);
            }
            catch(Exception ex)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos alterar sua senha, tente novamente, detalhe do erro: {ex.Message}";
                return View("Index", alterarSenhaModel);
            }
        }
    }
}
