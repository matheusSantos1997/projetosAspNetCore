using CadastroPessoa.Infra.Data.Configurations;

namespace CadastroPessoa.API.Configurations
{
    public static class DependencyInjectionExtensions
    {
        private static IConfiguration _configuration = null!;

        public static IServiceCollection AddAPI(this IServiceCollection services, IConfiguration configuration)
        {
            _configuration = configuration;
            
            services.AddInfrastructureData(_configuration);

            return services;
        }
    }
}