using Microsoft.AspNetCore.Mvc;

namespace VendasLanches.Controllers
{
    public class ContatoController : Controller
    {
        public ContatoController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}