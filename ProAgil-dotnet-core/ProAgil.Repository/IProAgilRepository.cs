using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface IProAgilRepository
    {
         //Geral
         void Add<T>(T entity) where T : class; // interface de adicionar
         void Update<T>(T entity) where T : class; // interface de atualizar
         void Delete<T>(T entity) where T : class; // interface que vai deletar

         void DeleteRange<T>(T[] entity) where T: class;
         Task<bool> SaveChangesAsync(); // salva as alteracoes

         //Eventos

         // todos os eventos de um determinado tema
         Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrantes);

         // todos os eventos em geral 
         Task<Evento[]> GetAllEventoAsync(bool includePalestrantes);

         // unico evento por id
         Task<Evento> GetEventoAsyncById(int EventoId, bool includePalestrantes);

         //Palestrante
         Task<Palestrante[]> GetAllPalestrantesAsyncByName(string name, bool includePalestrantes);
         Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool includePalestrantes);
    }
}