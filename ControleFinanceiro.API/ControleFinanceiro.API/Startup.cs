using ControleFinanceiro.API.Extensions;
using ControleFinanceiro.API.Validacoes;
using ControleFinanceiro.API.ViewModels;
using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL;
using ControleFinanceiro.DAL.Interfaces;
using ControleFinanceiro.DAL.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

            services.ConfigurarSenhaUsuario();

            // escopo interfaces e repositorios
            services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddScoped<ITipoRepositorio, TipoRepositorio>();
            services.AddScoped<IFuncaoRepositorio, FuncaoRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<ICartaoRepositorio, CartaoRepositorio>();

            // chamando o fluent validation
            services.AddTransient<IValidator<Categoria>, CategoriaValidator>(); // valida�ao de Categoria
            services.AddTransient<IValidator<FuncoesViewModel>, FuncoesValidator>(); // valida�ao de Funcao
            services.AddTransient<IValidator<RegistroViewModel>, RegistroValidator>(); // valida�ao registro usuario
            services.AddTransient<IValidator<LoginViewModel>, LoginValidator>(); // valida�ao login usuario
            services.AddTransient<IValidator<Cartao>, CartaoValidator>(); // valida�ao cartao usuario

            services.AddCors(); // habilita o cors

            //configurando arquivos est�ticos do angular spa
            services.AddSpaStaticFiles(diretory =>
            {
                diretory.RootPath = "ControleFinanceiro-UI"; // caminho do projeto angular
            });

            var key = Encoding.ASCII.GetBytes(Settings.ChaveSecreta); // codificara a chave secreta do usuario

            services.AddAuthentication(opcoes =>
            {
                opcoes.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opcoes.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(opcoes =>
            {
                opcoes.RequireHttpsMetadata = false; // nao ser� necessario o uso do https
                opcoes.SaveToken = true; // salva o token
                opcoes.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true, // faz com que o token seja validado
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };

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

            // pode ser qualque origem. metodo e cabe�alho
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

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
