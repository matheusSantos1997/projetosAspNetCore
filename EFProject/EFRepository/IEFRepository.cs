using System.Collections.Generic;
using System.Threading.Tasks;
using EFDomain;

namespace EFRepository
{
    public interface IEFRepository
    {
         //Geral
         void Add<T>(T entity) where T : class; // interface de adicionar
         void Update<T>(T entity) where T : class; // interface de atualizar
         void Delete<T>(T entity) where T : class; // interface que vai deletar
         
         // Task é utilizado quando trabalha de forma assincrona
         Task<bool> SaveChangesAsync(); // salva as alteracoes
        
         // heroi
         // Task<Heroi[]> GetAllHeroiAsync(bool includeBatalhas = false);
         Task<List<Heroi>> GetAllHeroiAsync(bool includeBatalhas = false);

         Task<Heroi[]> GetAllHeroiAsyncByName(string name, bool includeBatalhas = false);

         Task<Heroi> GetHeroiAsyncById(int id, bool includeBatalhas = false);

         // batalhas
         Task<Batalha[]> GetAllBatalhaAsyncByName(string name, bool includeHerois = false);

         Task<Batalha> GetBatalhaAsync(int batalhaId, bool includeHerois = false);
    }
}