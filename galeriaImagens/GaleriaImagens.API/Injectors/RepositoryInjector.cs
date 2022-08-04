using GaleriaImagens.Application.Interfaces;
using GaleriaImagens.Application.Services;
using GaleriaImagens.Repository.Interfaces;
using GaleriaImagens.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GaleriaImagens.API.Injectors
{
    public static class RepositoryInjector
    {
        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IImagemService, ImagemService>();
            services.AddScoped<IRepositoryGeneric, RepositoryGeneric>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IImagemRepository, ImagemRepository>();      
        }
    }
}