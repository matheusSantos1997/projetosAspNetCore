using VendasLanches.Models;

namespace VendasLanches.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche>? Lanches { get; set; }

        public string? CategoriaAtual { get; set; }
    }
}