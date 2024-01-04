using CrudContatosMvc.Filters;
using CrudContatosMvc.Models;
using CrudContatosMvc.Repositories;
using Microsoft.AspNetCore.Mvc;
using PagedList;

namespace CrudContatosMvc.Controllers
{
    [PaginaRestritaSomenteAdmin]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        private readonly IContatoRepository _contatoRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository, IContatoRepository contatoRepository)
        {
            _usuarioRepository = usuarioRepository;
            _contatoRepository = contatoRepository;
        }

        public IActionResult Index(int? page)
        {
            int pageSize = 3;
            int pageNumber = (page ?? 1);

            var usuarios = _usuarioRepository.BuscarTodos();

            // Calcular a quantidade de itens a serem pulados para a página desejada
            int itemsToSkip = (pageNumber - 1) * pageSize;

            // Obter os itens da página atual
            var paginaDeItens = usuarios.Skip(itemsToSkip).Take(pageSize).ToList();

            // Calcular o número total de páginas
            int totalItems = usuarios.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Criar um objeto PagedList manualmente
            var pagedList = new StaticPagedList<UsuarioModel>(paginaDeItens, pageNumber, pageSize, totalItems);

            return View(pagedList);
        }

        public IActionResult ListarContatosPorUsuarioId(int id, int? modalPage)
        {
           

            var contatos = _contatoRepository.BuscarTodos(id);

            return PartialView("_ContatosUsuario", contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    usuario = _usuarioRepository.Adicionar(usuario);

                    TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(usuario);
            }
            catch(Exception ex)
            {
               TempData["MensagemErro"] = $"ops, houve um erro ao tentar cadastrar, tente novamente, detalhe do erro: {ex.Message}";
                return RedirectToAction("index");
            }
        }

        public IActionResult Editar(int id)
        {
            var usuario = _usuarioRepository.ListarPorId(id);
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Editar(UsuarioSemSenhaModel usuarioSemSenha)
        {
            try
            {
                UsuarioModel? usuario = null;
                if(ModelState.IsValid)
                {
                    usuario = new UsuarioModel()
                    {
                        Id = usuarioSemSenha.Id,
                        Nome = usuarioSemSenha.Nome,
                        Login = usuarioSemSenha.Login,
                        Email = usuarioSemSenha.Email,
                        Perfil = usuarioSemSenha.Perfil ?? 0
                    };

                    usuario = _usuarioRepository.Atualizar(usuario);
                    TempData["MensagemSucesso"] = "Usuário atualizado com sucesso!";

                    return RedirectToAction("Index");

                }

                return View(usuario);
            }
            catch(Exception ex)
            {
                TempData["MensagemErro"] = $"ops, houve um erro ao tentar atualizar, tente novamente, detalhe do erro: {ex.Message}";
                return RedirectToAction("index");
            }
        }

        public IActionResult ExcluirConfirmacao(int id)
        {
            var usuario = _usuarioRepository.ListarPorId(id);
            return View(usuario);
        }

        public IActionResult Excluir(int id)
        {
            try
            {
                bool deletado = _usuarioRepository.Excluir(id);

                if (deletado)
                {
                    TempData["MensagemSucesso"] = "Usuário excluído com sucesso!";
                }
                else
                {
                    TempData["MensagemSucesso"] = "Ops, não conseguimos deletar seu usuário!";
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"ops, houve um erro ao tentar excluir, tente novamente, detalhe do erro: {ex.Message}";
                return RedirectToAction("index");
            }
        }
    }
}
