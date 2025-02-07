using CadastroPessoa.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CadastroPessoa.Infra.Data.Configurations
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddInfrastructureData(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>();
            services.RunMigrations(configuration);
            return services;
        }

        private static IServiceCollection RunMigrations(this IServiceCollection services, IConfiguration configuration)
        {
            var runMigrations = configuration.GetValue<bool>("RunMigrations");
            using var serviceProvider = services.BuildServiceProvider();
            using var appDbContext = serviceProvider.GetRequiredService<AppDbContext>();

            if(runMigrations)
            {
                appDbContext.Database.Migrate();
            }

            return services;
        }
    }
}