using Postagens.Application.Interfaces;
using Postagens.Application.Services;
using Postagens.Repository.Interfaces;
using Postagens.Repository.Repositories;

namespace Postagens.API.Injectors
{
    public static class RepositoryInjector
    {
        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IGenericRepository, GenericRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IPostService, PostService>();
        }
    }
}
