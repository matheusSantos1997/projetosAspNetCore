using System.Linq;
using AutoMapper;
using ProAgil.API.Dtos;
using ProAgil.Domain;

namespace ProAgil.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        // construtor
        public AutoMapperProfiles()
        {
            // cria o mapeamento entre os dtos e as classes
            //referenciando n:n
            CreateMap<Evento, EventoDto>() // mapeamento entre o Evento e o EventoDto
                 .ForMember(dest => dest.Palestrantes, opt => // destinatario palestrantes 
                 {
                     // diz que a associaçao de Evento vem de palestrantEvento
                     opt.MapFrom(src => src.PalestrantesEventos.Select(x => x.Palestrante).ToList());
                 }).ReverseMap();

            CreateMap<Palestrante, PalestranteDto>() // mapeamento entre Palestrante entre Palestrante e PalestranteDto
                 .ForMember(dest => dest.Eventos, opt =>
                 {
                     opt.MapFrom(src => src.PalestrantesEventos.Select(x => x.Evento).ToList());
                 }).ReverseMap();

            CreateMap<Lote, LoteDto>().ReverseMap(); // mapeamento entre Lote e LoteDto  

            CreateMap<RedeSocial, RedeSocialDto>().ReverseMap(); // mapeamento entre RedeSocial e RedeSocialDto 
        }
    }
}