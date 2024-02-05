using VendasLanches.Context;
using VendasLanches.Interfaces;
using VendasLanches.Models;

namespace VendasLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly LanchesContext _context;

        public CategoriaRepository(LanchesContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}