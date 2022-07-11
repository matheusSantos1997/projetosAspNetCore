using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Models;
using ProEventos.Repository.Context;
using ProEventos.Repository.Interfaces;

namespace ProEventos.Repository.Repositories
{
    public class ProEventosPalestranteRepository : IProEventosPalestranteRepository
    {
        private readonly DataContext _context;

        public ProEventosPalestranteRepository(DataContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; 
        }

        public async Task<List<Palestrante>> GetAllPalestrantesAsync(bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                                                    .Include(p => p.RedesSociais);
            
            if(includeEventos)
            {
                query.Include(p => p.PalestrantesEventos)
                     .ThenInclude(pe => pe.Evento);
            }

            query = query.AsNoTracking()
                         .OrderBy(p => p.Id);

            return await query.ToListAsync();
        }

        public async Task<List<Palestrante>> GetAllPelestrantesByNomeAsync(string nome, bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                                                    .Include(p => p.RedesSociais);
            
            if(includeEventos)
            {
                query.Include(p => p.PalestrantesEventos)
                     .ThenInclude(pe => pe.Evento);
            }

            query = query.AsNoTracking()
                         .OrderBy(p => p.Id)
                         .Where(p => p.Nome.ToLower().Contains(nome.ToLower()));

            return await query.ToListAsync();
        }

        public async Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                                                    .Include(p => p.RedesSociais);
            
            if(includeEventos)
            {
                query.Include(p => p.PalestrantesEventos)
                     .ThenInclude(pe => pe.Evento);
            }

            query = query.AsNoTracking()
                         .OrderBy(p => p.Id)
                         .Where(p => p.Id == palestranteId);

            return await query.FirstOrDefaultAsync();
        }
    }
}