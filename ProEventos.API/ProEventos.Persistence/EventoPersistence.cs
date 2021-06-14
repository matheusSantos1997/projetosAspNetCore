using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.context;
using ProEventos.Persistence.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence
{
    public class EventoPersistence : IEventoPersistence
    {
        private readonly ProEventosContext _context;

        public EventoPersistence(ProEventosContext context)
        {
            _context = context;
           // _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<Evento[]> GetAllEventosAsync(bool includePalestrantes)
        {
            IQueryable<Evento> query = _context.Eventos
                                               .Include(e => e.Lotes)
                                               .Include(e => e.RedesSociais);

            if(includePalestrantes)
            {
                query = query
                    .Include(p => p.PalestrantesEventos)
                    .ThenInclude(pe => pe.Palestrante);
            }

            query = query
                .AsNoTracking()
                .OrderBy(e => e.EventoId);

            return await query.ToArrayAsync();


        }

        public async Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes)
        {
            IQueryable<Evento> query = _context.Eventos
                                               .Include(e => e.Lotes)
                                               .Include(e => e.RedesSociais);

            if (includePalestrantes)
            {
                query = query
                    .Include(p => p.PalestrantesEventos)
                    .ThenInclude(pe => pe.Palestrante);
            }

            query = query
                    .AsNoTracking()
                    .OrderBy(e => e.EventoId)
                    .Where(e => e.Tema.ToLower().Contains(tema.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Evento> GetEventosByIdAsync(int EventoId, bool includePalestrantes)
        {
            IQueryable<Evento> query = _context.Eventos
                                               .Include(e => e.Lotes)
                                               .Include(e => e.RedesSociais);

            if (includePalestrantes)
            {
                query = query
                    .Include(p => p.PalestrantesEventos)
                    .ThenInclude(pe => pe.Palestrante);
            }

            query = query
                    .AsNoTracking()
                    .OrderBy(e => e.EventoId)
                    .Where(e => e.EventoId == EventoId);

            return await query.FirstOrDefaultAsync();
        }

    }
}
