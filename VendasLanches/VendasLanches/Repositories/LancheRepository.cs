using Microsoft.EntityFrameworkCore;
using VendasLanches.Context;
using VendasLanches.Interfaces;
using VendasLanches.Models;

namespace VendasLanches.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly LanchesContext _context;

        public LancheRepository(LanchesContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l => l.IsLanchePreferido)
                                                                        .Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId)!;
        }
    }
}