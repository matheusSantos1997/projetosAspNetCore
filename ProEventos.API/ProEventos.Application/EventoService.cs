using ProEventos.Application.interfaces;
using ProEventos.Domain;
using ProEventos.Persistence.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Application
{
    public class EventoService : IEventoService
    {
        private readonly IGeralPersistence _geralPersistence;

        private readonly IEventoPersistence _eventoPersistence;
        
        public EventoService(IGeralPersistence geralPersistence, IEventoPersistence eventoPersistence)
        {
            _geralPersistence = geralPersistence;
            _eventoPersistence = eventoPersistence;
        }

        public async Task<Evento> AddEventos(Evento model)
        {
            try
            {
                _geralPersistence.Add<Evento>(model); // adiciona o evento

                // se foi salvo
                bool save = await _geralPersistence.SaveChangesAsync();

                if (save)
                {
                    // return Ok()
                    return await _eventoPersistence.GetEventosByIdAsync(model.EventoId, false);
                }

                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Evento> UpdateEvento(int eventoId, Evento model)
        {
            try
            {
                var evento = await _eventoPersistence.GetEventosByIdAsync(eventoId, false);

                model.EventoId = evento.EventoId;

                // verificaçao se um evento foi retornado ou nao
                if (evento == null)
                {
                    return null;
                }

                _geralPersistence.Update<Evento>(model);

                // se foi salvo
                bool save = await _geralPersistence.SaveChangesAsync();

                if (save)
                {
                    // return Ok()
                    return await _eventoPersistence.GetEventosByIdAsync(model.EventoId, false);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteEvento(int eventoId)
        {
            try
            {
                var evento = await _eventoPersistence.GetEventosByIdAsync(eventoId, false);

                if (evento == null)
                {
                    throw new Exception("Evento não foi encontrado para ser excluido.");
                }

                _geralPersistence.Delete<Evento>(evento);
                return await _geralPersistence.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false)
        {
            try
            {
                var eventos = await _eventoPersistence.GetAllEventosAsync(includePalestrantes);

                if (eventos == null) return null;

                return eventos;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false)
        {
            try
            {
                var eventos = await _eventoPersistence.GetAllEventosByTemaAsync(tema, includePalestrantes);

                if (eventos == null) return null;

                return eventos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Evento> GetEventosByIdAsync(int eventoId, bool includePalestrantes = false)
        {
            try
            {
                var eventos = await _eventoPersistence.GetEventosByIdAsync(eventoId, includePalestrantes);

                if (eventos == null) return null;

                return eventos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
