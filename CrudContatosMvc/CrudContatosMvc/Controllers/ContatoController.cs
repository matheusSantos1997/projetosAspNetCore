using CrudContatosMvc.Models;
using CrudContatosMvc.Repositories;
using Microsoft.AspNetCore.Mvc;
using PagedList;

namespace CrudContatosMvc.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public IActionResult Index(int? page)
        {
            int pageSize = 3;
            int pageNumber = (page ?? 1);

            var contatos = _contatoRepository.BuscarTodos();

            // Calcular a quantidade de itens a serem pulados para a página desejada
            int itemsToSkip = (pageNumber - 1) * pageSize;

            // Obter os itens da página atual
            var paginaDeItens = contatos.Skip(itemsToSkip).Take(pageSize).ToList();

            // Calcular o número total de páginas
            int totalItems = contatos.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Criar um objeto PagedList manualmente
            var pagedList = new StaticPagedList<ContatoModel>(paginaDeItens, pageNumber, pageSize, totalItems);

            return View(pagedList);
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
