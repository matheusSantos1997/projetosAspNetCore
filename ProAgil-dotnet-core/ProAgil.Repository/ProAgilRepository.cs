using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    //classe que vai implementar a interface IProAgilRepository
    public class ProAgilRepository : IProAgilRepository
    {
        // passando o contexto co contrutor
        private readonly ProAgilContext _context;

        public ProAgilRepository(ProAgilContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        //MÉTODOS GERAIS

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity); // adiciona registros
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity); // atualiza registros
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity); // remove registros
        }

        public void DeleteRange<T>(T[] entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }
        public async Task<bool> SaveChangesAsync()
        {
            //se existe registro no banco de dados retorna e salva as mudanças
            bool results = await _context.SaveChangesAsync() > 0;
            return (results); // salva mudanças
        }

        //EVENTO
        public async Task<Evento[]> GetAllEventoAsync(bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos
                .Include(c => c.Lotes)
                .Include(c => c.RedesSociais);

            //se o includePalestrantes for igual a true
            if (includePalestrantes)
            {
                query = query
                      .Include(pe => pe.PalestrantesEventos)
                      .ThenInclude(p => p.Palestrante);
            }

            // vai ordenar a data do evento em ordem decrescente
            query = query.AsNoTracking()
                         .OrderBy(c => c.Id);

            return await query.ToArrayAsync(); // vai retornar a query com todos os eventos
        }
        public async Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrantes)
        {
            IQueryable<Evento> query = _context.Eventos
                .Include(c => c.Lotes)
                .Include(c => c.RedesSociais);

            //se o includePalestrantes for igual a true
            if (includePalestrantes)
            {
                query = query
                      .Include(pe => pe.PalestrantesEventos)
                      .ThenInclude(p => p.Palestrante);
            }

            query = query.AsNoTracking()
                         .OrderByDescending(c => c.DataEvento)
                         .Where(c => c.Tema.ToLower().Contains(tema.ToLower()));

            return await query.ToArrayAsync();
        }
        public async Task<Evento> GetEventoAsyncById(int EventoId, bool includePalestrantes)
        {
            IQueryable<Evento> query = _context.Eventos
                .Include(c => c.Lotes)
                .Include(c => c.RedesSociais);

            //se o includePalestrantes for igual a true
            if (includePalestrantes)
            {
                query = query
                      .Include(pe => pe.PalestrantesEventos)
                      .ThenInclude(p => p.Palestrante);
            }

            query = query.AsNoTracking()
                         .OrderBy(c => c.DataEvento)
                         .Where(c => c.Id == EventoId);

            return await query.FirstOrDefaultAsync();
        }

        //PALESTRANTE

        // vai retornar apenas um palestrante
        public async Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                    .Include(c => c.RedesSociais);

            //se o includePalestrantes for igual a true
            if (includeEventos)
            {
                query = query
                      .Include(pe => pe.PalestrantesEventos)
                      .ThenInclude(e => e.Evento);
            }

            //ordenaçao por nome do palestrante
            query = query.AsNoTracking()
                         .OrderBy(p => p.Nome)
                         .Where(p => p.Id == PalestranteId);

            return await query.FirstOrDefaultAsync();

        }
        public async Task<Palestrante[]> GetAllPalestrantesAsyncByName(string name, bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                .Include(c => c.RedesSociais);

            //se o includePalestrantes for igual a true
            if (includeEventos)
            {
                query = query
                      .Include(pe => pe.PalestrantesEventos)
                      .ThenInclude(e => e.Evento);
            }

            //ordenaçao por nome do palestrante
            query = query.AsNoTracking()
                         .Where(p => p.Nome.ToLower().Contains(name.ToLower()));

            return await query.ToArrayAsync();
        }

    }
}