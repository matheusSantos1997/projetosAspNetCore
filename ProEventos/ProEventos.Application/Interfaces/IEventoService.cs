using System.Collections.Generic;
using System.Threading.Tasks;
using ProEventos.Domain.Models;

namespace ProEventos.Application.Interfaces
{
    public interface IEventoService
    {
        Task<Evento> AddEventos(Evento model);

        Task<Evento> UpdateEvento(int eventoId, Evento model);

        Task<bool> DeleteEvento(int eventoId);

        //Eventos
        Task<List<Evento>> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);

        Task<List<Evento>> GetAllEventosAsync(bool includePalestrantes = false);

        Task<Evento> GetEventosByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}