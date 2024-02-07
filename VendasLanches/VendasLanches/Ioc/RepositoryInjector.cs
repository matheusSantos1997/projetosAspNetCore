using VendasLanches.Interfaces;
using VendasLanches.Models;
using VendasLanches.Repositories;

namespace VendasLanches.Ioc
{
    public static class RepositoryInjector
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ILancheRepository, LancheRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();

            return services;
        }

        public static IServiceCollection RegisterHttpContextAcessor(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => CarrinhoCompra.GetCarrinho(sp));

            return services;
        }
    }
}