using CrudContatosMvc.Models;
using CrudContatosMvc.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CrudContatosMvc.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public IActionResult Index()
        {
            var contatos = _contatoRepository.BuscarTodos();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            var contato = _contatoRepository.ListarPorId(id);
            return View(contato);
        }

        public IActionResult ExcluirConfirmacao(int id)
        {
            var contato = _contatoRepository.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Excluir(int id)
        {
            try
            {
                bool deletado = _contatoRepository.Excluir(id);

                if (deletado)
                {
                    TempData["MensagemSucesso"] = "Contato excluído com sucesso!";
                }
                else
                {
                    TempData["MensagemSucesso"] = "Ops, não conseguimos deletar seu contato!";
                }

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["MensagemErro"] = $"ops, houve um erro ao tentar excluir, tente novamente, detalhe do erro: {ex.Message}";
                return RedirectToAction("index");
            }
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepository.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso!";

                    return RedirectToAction("Index");
                }

                return View(contato);
            }
            catch(Exception ex)
            {
                TempData["MensagemErro"] = $"ops, houve um erro ao tentar cadastrar, tente novamente, detalhe do erro: {ex.Message}";
                return RedirectToAction("index");
            }
            
        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepository.Atualizar(contato);
                    TempData["MensagemSucesso"] = "Contato atualizado com sucesso!";

                    return RedirectToAction("Index");
                }

                return View("Editar", contato);
            }
            catch(Exception ex)
            {
                TempData["MensagemErro"] = $"ops, houve um erro ao tentar atualizar, tente novamente, detalhe do erro: {ex.Message}";
                return RedirectToAction("index");
            }
        }
    }
}
