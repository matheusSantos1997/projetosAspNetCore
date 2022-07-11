using Microsoft.Extensions.DependencyInjection;
using ProEventos.Application.Interfaces;
using ProEventos.Application.Services;
using ProEventos.Repository.Interfaces;
using ProEventos.Repository.Repositories;

namespace ProEventos.API.Injectors
{
    public static class RepositoryInjector
    {
        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IEventoService, EventoService>();
            services.AddScoped<IProEventosEventoRepository, ProEventosEventoRepository>();
            services.AddScoped<IProEventosGeneric, ProEventosGeneric>();
        }
    }
}