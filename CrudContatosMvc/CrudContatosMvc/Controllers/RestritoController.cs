using CrudContatosMvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace CrudContatosMvc.Controllers
{
    [PaginaUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
