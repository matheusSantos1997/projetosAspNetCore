using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFDomain;
using Microsoft.EntityFrameworkCore;

namespace EFRepository
{
    public class EFDataBase : IEFRepository
    {
        private readonly HeroiContext _context;
        public EFDataBase(HeroiContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            bool results = await _context.SaveChangesAsync() > 0;
            return (results);
        }
        
        public async Task<List<Heroi>> GetAllHeroiAsync(bool includeBatalhas = false)
        {
            IQueryable<Heroi> query = _context.Herois
                 .Include(h => h.Armas)
                 .Include(h => h.Identidade);

            if(includeBatalhas) {
                  query = query.Include(h => h.HeroisBatalhas)
                         .ThenInclude(heroib => heroib.Batalha);
            }    
           
            
            query = query.AsNoTracking()
                         .OrderBy(h => h.Id);
            
            return await query.ToListAsync();
            
        }

        public async Task<Heroi[]> GetAllHeroiAsyncByName(string name, bool includeBatalhas = false)
        {
            IQueryable<Heroi> query = _context.Herois
                 .Include(h => h.Armas)
                 .Include(h => h.Identidade);
            
            if(includeBatalhas) {
                  query = query.Include(h => h.HeroisBatalhas)
                         .ThenInclude(heroib => heroib.Batalha);
            }   
            
            query = query.AsNoTracking()
                         .OrderBy(i => i.Id)
                         .Where(n => n.nome.ToLower().Contains(name.ToLower()));
            return await query.ToArrayAsync();
        }

        public async Task<Heroi> GetHeroiAsyncById(int id, bool includeBatalhas = false)
        {
            IQueryable<Heroi> query = _context.Herois
                   .Include(h => h.Armas)
                   .Include(h => h.Identidade);
            
            if(includeBatalhas) {
                  query = query.Include(h => h.HeroisBatalhas)
                         .ThenInclude(heroib => heroib.Batalha);
            }   

            query = query.AsNoTracking()
                         .OrderBy(n => n.nome)
                         .Where(i => i.Id == id);

            return await query.FirstOrDefaultAsync();
        }
         public async Task<Batalha[]> GetAllBatalhaAsyncByName(string name, bool includeHerois = false)
         {
             IQueryable<Batalha> query = _context.Batalhas;

             if (includeHerois)
             {
                query = query
                        .Include(hb => hb.HeroisBatalhas)
                        .ThenInclude(h => h.Heroi);
             }

            query = query.AsNoTracking()
                         .Where(b => b.Nome.ToLower().Contains(name.ToLower()));
            
            return await query.ToArrayAsync();
         }

        public async Task<Batalha> GetBatalhaAsync(int batalhaId, bool includeHerois = false)
        {
            IQueryable<Batalha> query = _context.Batalhas;

            if(includeHerois) 
            {
                query = query
                        .Include(hb => hb.HeroisBatalhas)
                        .ThenInclude(h => h.Heroi);
            }

            query = query.AsNoTracking()
                         .OrderBy(b => b.Nome)
                         .Where(b => b.Id == batalhaId);

            return await query.FirstOrDefaultAsync();
        }

    }
}