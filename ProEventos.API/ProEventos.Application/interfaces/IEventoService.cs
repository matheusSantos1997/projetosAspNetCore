using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Application.interfaces
{
    public interface IEventoService
    {
        Task<Evento> AddEventos(Evento model);

        Task<Evento> UpdateEvento(int eventoId, Evento model);

        Task<bool> DeleteEvento(int eventoId);

        //Eventos
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);

        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);

        Task<Evento> GetEventosByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}
