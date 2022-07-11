using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Models;
using ProEventos.Repository.Context;
using ProEventos.Repository.Interfaces;

namespace ProEventos.Repository.Repositories
{
    public class ProEventosEventoRepository : IProEventosEventoRepository
    {
        private readonly DataContext _context;

        public ProEventosEventoRepository(DataContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; 
        }

        public async Task<List<Evento>> GetAllEventosAsync(bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos
                                               .Include(e => e.Lotes)
                                               .Include(e => e.RedesSociais);
            if(includePalestrantes) 
            {
                query.Include(e => e.PalestrantesEventos)
                     .ThenInclude(pe => pe.Palestrante);
            }
            
            query = query.AsNoTracking()
                         .OrderBy(e => e.Id);

            return await query.ToListAsync();
        }

        public async Task<List<Evento>> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos
                                               .Include(e => e.Lotes)
                                               .Include(e => e.RedesSociais);

            if(includePalestrantes) 
            {
                query.Include(e => e.PalestrantesEventos)
                     .ThenInclude(pe => pe.Palestrante);
            }
            
            query = query.AsNoTracking()
                         .OrderBy(e => e.Id)
                         .Where(e => e.Tema.ToLower().Contains(tema.ToLower()));

            return await query.ToListAsync();

        }

        public async Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos
                                               .Include(e => e.Lotes)
                                               .Include(e => e.RedesSociais);

            if(includePalestrantes) 
            {
                query.Include(e => e.PalestrantesEventos)
                     .ThenInclude(pe => pe.Palestrante);
            }
            
            query = query.AsNoTracking()
                         .OrderBy(e => e.Id)
                         .Where(e => e.Id == eventoId);

            return await query.FirstOrDefaultAsync();
        }
    }
}