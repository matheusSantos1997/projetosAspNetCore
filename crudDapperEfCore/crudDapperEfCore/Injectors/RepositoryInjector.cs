using crudDapperEfCore.Interfaces;
using crudDapperEfCore.Models;
using crudDapperEfCore.Repositories;
using crudDapperEfCore.Services;
using crudDapperEfCore.Validations;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace crudDapperEfCore.Injectors
{
    public static class RepositoryInjector
    {
        public static void RegisterRepositories(IServiceCollection services)
        {
            // repositories, interfaces and services
            services.AddScoped<IGenericRepository, GenericRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteService, ClienteService>();

            // Models validation 
            services.AddScoped<IValidator<Cliente>, ClienteValidation>();
            services.AddScoped<IValidator<Produto>, ProdutoValidation>();
        }
    }
}
