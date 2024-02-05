
using Microsoft.AspNetCore.Mvc;
using VendasLanches.Interfaces;
using VendasLanches.Models;
using VendasLanches.ViewModels;

namespace VendasLanches.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List(string categoria)
        {
           IEnumerable<Lanche> lanches;
           string categoriaAtual = string.Empty;

           if(string.IsNullOrEmpty(categoria))
           {
              lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
              categoriaAtual = "Todos os Lanches";
           }
           else
           {
              /* if(string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
               {
                  lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Normal"))
                                                     .OrderBy(l => l.Nome);
               } 
               else if(string.Equals("Natural", categoria, StringComparison.OrdinalIgnoreCase))
               {
                  lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Natural"))
                                                    .OrderBy(l => l.Nome);
               }
               else 
               {       
                  lanches = _lancheRepository.Lanches;
                  categoria = "Todos os Lanches";
               } */
               if(_lancheRepository.Lanches.FirstOrDefault(l => l.Categoria.CategoriaNome == categoria) != null) 
               {
                   lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                                                  .OrderBy(l => l.Nome);
               } 
               else 
               {
                   lanches = _lancheRepository.Lanches;
                   categoria = "Todos os Lanches";
               }

               

               categoriaAtual = categoria;
           }
           
           var lanchesListViewModel = new LancheListViewModel
           {
              Lanches = lanches,
              CategoriaAtual = categoriaAtual
           };

           return View(lanchesListViewModel);
        }

        public IActionResult Details(int lancheId)
        {
            var lanche = _lancheRepository.GetLancheById(lancheId);

            return View(lanche);
        }
    }
}