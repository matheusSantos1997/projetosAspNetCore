using Microsoft.AspNetCore.Mvc;
using VendasLanches.Interfaces;

namespace VendasLanches.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaMenu(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categoria = _categoriaRepository.Categorias.OrderBy(c => c.CategoriaNome);
            return View("~/Views/Shared/Components/DefaultMenu.cshtml", categoria);
        }
    }
}