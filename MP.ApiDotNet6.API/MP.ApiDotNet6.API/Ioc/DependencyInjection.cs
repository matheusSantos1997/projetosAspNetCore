using Microsoft.EntityFrameworkCore;
using MP.ApiDotnet6.Application.Services.Interfaces;
using MP.ApiDotnet6.Application.Services;
using MP.ApiDotNet6.Infra.Data.Context;
using MP.ApiDotNet6.Infra.Data.Repositories;
using MP.ApiDotNet6.Infra.Data.Repositories.Interfaces;

namespace MP.ApiDotNet6.API.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraStructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                string conn = configuration.GetConnectionString("DefaultConnection");
                opt.UseNpgsql(conn);
            });

            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IPurchaseRepository, PurchaseRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddAutoMapper(typeof(DomainToDtoMapping));
            //services.AddAutoMapper(typeof(DtoToDomainMapping));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IPurchaseService, PurchaseService>();
            

            return services;
        }
    }
}
