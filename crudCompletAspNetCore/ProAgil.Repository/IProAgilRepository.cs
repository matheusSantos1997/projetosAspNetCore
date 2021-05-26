using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface IProAgilRepository
    {
         //Geral
         void Add<T>(T entity) where T : class; // interface de adicionar
         void Update<T>(T entity) where T : class; // interface de atualizar
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveChangesAsync();

         //Eventos
         Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrantes);
         Task<Evento[]> GetAllEventoAsync(bool includePalestrantes);
         Task<Evento> GetEventoAsyncById(int EventoId, bool includePalestrantes);

         //Palestrante
         Task<Palestrante[]> GetAllPalestrantesAsyncByName(string name, bool includePalestrantes);
         Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool includePalestrantes);

    }
}