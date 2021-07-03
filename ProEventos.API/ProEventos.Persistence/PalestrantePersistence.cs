using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.context;
using ProEventos.Persistence.interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Persistence
{
    public class PalestrantePersistence : IPalestrantePersistence
    {
        private readonly ProEventosContext _context;

        public PalestrantePersistence(ProEventosContext context)
        {
            _context = context;
        }

        public async Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                                                    .Include(p => p.RedeSocials);

            if (includeEventos)
            {
                query = query
                    .Include(p => p.PalestrantesEventos)
                    .ThenInclude(pe => pe.Evento);
            }

            query = query
                .AsNoTracking()
                .OrderBy(p => p.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                                                    .Include(p => p.RedeSocials);

            if (includeEventos)
            {
                query = query
                    .Include(p => p.PalestrantesEventos)
                    .ThenInclude(pe => pe.Evento);
            }

            query = query
                    .AsNoTracking()
                    .OrderBy(p => p.Id)
                    .Where(p => p.Nome.ToLower().Contains(nome.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante> GetPalestrantesByIdAsync(int PalestranteId, bool includeEventos)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                                                    .Include(p => p.RedeSocials);

            if (includeEventos)
            {
                query = query
                    .Include(p => p.PalestrantesEventos)
                    .ThenInclude(pe => pe.Evento);
            }

            query = query
                     .AsNoTracking()
                     .OrderBy(p => p.Id)
                     .Where(p => p.Id == PalestranteId);

            return await query.FirstOrDefaultAsync();
        }
    }
}
