using crudDapperEfCore.DTOs.Cliente;
using crudDapperEfCore.DTOs.Produto;
using crudDapperEfCore.Interfaces;
using crudDapperEfCore.Models;
using crudDapperEfCore.Repositories;
using crudDapperEfCore.Services;
using crudDapperEfCore.Services.Exports;
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
            services.AddScoped<IExcelExportService, ExcelExportService>();

            // Models validation 
            services.AddScoped<IValidator<CreateNewClienteDTO>, ClienteValidation>();
            services.AddScoped<IValidator<CreateNewProdutoDTO>, ProdutoValidation>();
        }
    }
}
