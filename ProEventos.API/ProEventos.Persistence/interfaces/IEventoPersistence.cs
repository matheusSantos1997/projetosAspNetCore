using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.interfaces
{
    public interface IEventoPersistence
    {

        //Eventos
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);

        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);

        Task<Evento> GetEventosByIdAsync(int EventoId, bool includePalestrantes = false);

    }
}
