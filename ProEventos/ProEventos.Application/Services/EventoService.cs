using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProEventos.Application.Interfaces;
using ProEventos.Domain.Models;
using ProEventos.Repository.Interfaces;

namespace ProEventos.Application.Services
{
    public class EventoService : IEventoService
    {
        private readonly IProEventosGeneric _genericRepository;
        private readonly IProEventosEventoRepository _eventoRepository;

        public EventoService(IProEventosGeneric genericRepository, IProEventosEventoRepository eventoRepository)
        {
            _genericRepository = genericRepository;
            _eventoRepository = eventoRepository;
        }

        public async Task<Evento> AddEventos(Evento model)
        {
            try
            {
                _genericRepository.Add<Evento>(model);

                bool save = await _genericRepository.SaveChangesAsync();

                if(save)
                {
                    return await _eventoRepository.GetEventoByIdAsync(model.Id, false);
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
                var evento = await _eventoRepository.GetEventoByIdAsync(eventoId, false); // busca um evento especifico

                model.Id = evento.Id;

                // verificaçao se um evento foi retornado ou nao
                if (evento == null)
                {
                    return null;
                }

                _genericRepository.Uptate<Evento>(model);

                // se foi salvo
                bool save = await _genericRepository.SaveChangesAsync();

                if(save)
                {
                    return await _eventoRepository.GetEventoByIdAsync(model.Id, false);
                }

                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteEvento(int eventoId)
        {
            try
            {
                var evento = await _eventoRepository.GetEventoByIdAsync(eventoId, false);

                // se o evento nao for encontrado para ser excluido
                if (evento == null)
                {
                    throw new Exception("Evento não foi encontrado para ser excluido.");
                    // return false;
                }

                _genericRepository.Delete<Evento>(evento);

                return await _genericRepository.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Evento>> GetAllEventosAsync(bool includePalestrantes = false)
        {
            try
            {
                var eventos = await _eventoRepository.GetAllEventosAsync(false);

                if(eventos == null) 
                {
                    return null;
                }
                

                return eventos;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Evento>> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false)
        {
            try
            {
                 var eventos = await _eventoRepository.GetAllEventosByTemaAsync(tema, false);

                 if(eventos == null)
                 {
                    return null;
                 }

                 return eventos;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Evento> GetEventosByIdAsync(int eventoId, bool includePalestrantes = false)
        {
            try
            {
                var evento = await _eventoRepository.GetEventoByIdAsync(eventoId, false);

                if(evento == null)
                {
                    return null;
                }

                return evento;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}