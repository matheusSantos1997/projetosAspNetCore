using Microsoft.Extensions.DependencyInjection;
using registerUsers.Interfaces;
using registerUsers.Repositories;
using registerUsers.Services;

namespace registerUsers.core
{
    public static class RepositoryInjector
    {
        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();
        }
    }
}