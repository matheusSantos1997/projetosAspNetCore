using System.Collections.Generic;
using System.Threading.Tasks;
using ProEventos.Domain.Models;

namespace ProEventos.Repository.Interfaces
{
    public interface IProEventosEventoRepository
    {
        // Eventos
        Task<List<Evento>> GetAllEventosByTemaAsync(string tema, bool includePalestrantes);
        Task<List<Evento>> GetAllEventosAsync(bool includePalestrantes);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes);
    }
}