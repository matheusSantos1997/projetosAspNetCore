using ControleFinanceiro.API.Validacoes;
using ControleFinanceiro.API.ViewModels;
using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL.Interfaces;
using ControleFinanceiro.DAL.Repositories;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace ControleFinanceiro.API.Ioc
{
    public static class RepositoryInjector
    {
        public static void RegisterRepositories(IServiceCollection services)
        {
            // escopo interfaces e repositorios
            services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddScoped<IDespesaRepositorio, DespesaRepositorio>();
            services.AddScoped<ITipoRepositorio, TipoRepositorio>();
            services.AddScoped<IMesRepositorio, MesRepositorio>();
            services.AddScoped<IFuncaoRepositorio, FuncaoRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<ICartaoRepositorio, CartaoRepositorio>();
            services.AddScoped<IGanhosRepositorio, GanhoRepositorio>();
            services.AddScoped<IGraficoRepositorio, GraficoRepositorio>();

            // chamando o fluent validation
            services.AddTransient<IValidator<Categoria>, CategoriaValidator>(); // validaçao de Categoria
            services.AddTransient<IValidator<FuncoesViewModel>, FuncoesValidator>(); // validaçao de Funcao
            services.AddTransient<IValidator<RegistroViewModel>, RegistroValidator>(); // validaçao registro usuario
            services.AddTransient<IValidator<LoginViewModel>, LoginValidator>(); // validaçao login usuario
            services.AddTransient<IValidator<AtualizarUsuarioViewModel>, AtualizarUsuarioViewModelValidator>(); // validaçao atualizar usuario
            services.AddTransient<IValidator<Cartao>, CartaoValidator>(); // validaçao cartao usuario
            services.AddTransient<IValidator<Despesa>, DespesaValidator>(); // validaçao despesa
            services.AddTransient<IValidator<Ganho>, GanhoValidator>();
        }
    }
}
