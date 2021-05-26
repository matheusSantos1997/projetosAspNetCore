using System.Linq;
using AutoMapper;
using ProAgil.API.Dtos;
using ProAgil.Domain;
using ProAgil.Domain.Identity;

namespace ProAgil.API.Helpers
{
    // associanto as classes de dominios aos dtos
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
                     opt.MapFrom(src => src.PalestrantesEventos.Select(x => x.Palestrante).ToList());
                 }).ReverseMap();

            CreateMap<Palestrante, PalestranteDto>() // mapeamento entre Palestrante entre Palestrante e PalestranteDto
                 .ForMember(dest => dest.Eventos, opt =>
                 {
                     opt.MapFrom(src => src.PalestrantesEventos.Select(x => x.Evento).ToList());
                 }).ReverseMap();

            CreateMap<Lote, LoteDto>().ReverseMap(); // mapeamento entre Lote e LoteDto  

            CreateMap<RedeSocial, RedeSocialDto>().ReverseMap(); // mapeamento entre RedeSocial e RedeSocialDto 

            CreateMap<User, UserDto>().ReverseMap(); // mapeamento entre o User e o UserDto

            CreateMap<User, UserLoginDto>().ReverseMap(); // mapeamento ente o User e o UserLoginDto
        }
    }
}