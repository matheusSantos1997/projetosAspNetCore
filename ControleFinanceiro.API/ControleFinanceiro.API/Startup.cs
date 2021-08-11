using ControleFinanceiro.API.Validacoes;
using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL;
using ControleFinanceiro.DAL.Interfaces;
using ControleFinanceiro.DAL.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Contexto>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("ConexaoDB"));
            });

            services.AddIdentity<Usuario, Funcao>().AddEntityFrameworkStores<Contexto>();

            services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddScoped<ITipoRepositorio, TipoRepositorio>();

            services.AddTransient<IValidator<Categoria>, CategoriaValidator>();

            services.AddCors(); // habilita o cors

            //configurando arquivos estáticos do angular spa
            services.AddSpaStaticFiles(diretory =>
            {
                diretory.RootPath = "ControleFinanceiro-UI"; // caminho do projeto angular
            });

            services.AddControllers()
                    .AddFluentValidation()
                    .AddJsonOptions(options =>
                    {
                        options.JsonSerializerOptions.IgnoreNullValues = true; // api ignora os valores nulos
                    })
                    .AddNewtonsoftJson(options =>
                    {
                        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; // ignora referencias circulares
                    });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // pode ser qualque origem. metodo e cabeçalho
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseStaticFiles(); // vai usar arquivos staticos 
            app.UseSpaStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // para reconhecer os arquivos no spa
            app.UseSpa(spa =>
            {
                // combina o diretorio atual com o projeto do angular
                spa.Options.SourcePath = Path.Combine(Directory.GetCurrentDirectory(), "ControleFinanceiro-UI");

                if (env.IsDevelopment())
                {
                    spa.UseProxyToSpaDevelopmentServer($"http://localhost:4200/"); // permiti executar a api e o angular juntos
                }
            });
        }
    }
}
