using crudDapperEfCore.API.DTOs.Validations;
using crudDapperEfCore.API.Repositories;
using crudDapperEfCore.API.Repositories.Interfaces;
using crudDapperEfCore.API.Services;
using crudDapperEfCore.API.Services.Exports;
using crudDapperEfCore.API.Services.Interfaces;
using FluentValidation;

namespace crudDapperEfCore.API.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IGenericRepository, GenericRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();

            return services;
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IExcelExportService, ExcelExportService>();

            return services;
        }

        public static IServiceCollection RegisterFluentValidations(this IServiceCollection services)
        {
           services.AddValidatorsFromAssemblyContaining<ClienteDTOValidation>();
           services.AddValidatorsFromAssemblyContaining<ProdutoDTOValidation>();
           services.AddValidatorsFromAssemblyContaining<ClienteUpdateDTOValidation>();
           services.AddValidatorsFromAssemblyContaining<ProdutoUpdateDTOValidation>();

           return services;
        }
    }
}