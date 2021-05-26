using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ProAgil.Domain.Identity;
using ProAgil.Repository;

namespace ProAgil.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) //método construtor
        {
            Configuration = configuration; //quando inicia a configuraçao
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // conexao com banco de dados
            services.AddDbContext<ProAgilContext>( //injeta no GetConnectionString
                x => x.UseSqlite(Configuration.GetConnectionString("DefaultConnection"))
                // "ConnectionStrings":{ "DefaultConnection":"Data Source=ProAgil.db" } 
            );
            
            // configuraçoes de controle de senhas no IdentityCore quando toda vez for adicionar um usuario
            IdentityBuilder builder = services.AddIdentityCore<User>(options => 
            {
                 options.Password.RequireDigit = false; // para nao ser obrigatorio utilizar caracteres especiais
                 options.Password.RequireNonAlphanumeric = false; // nao alpha numerico com nmeros e letras
                 options.Password.RequireLowercase = false; // nao permitir letras minusculas
                 options.Password.RequireUppercase = false; // nao permitir letrar maiusculas
                 options.Password.RequiredLength = 4; // limitando a quantidade de caracteres
            });
            
            /* criando o builder sendo instancia do IdentyBuilder com userType do tipo role 
            e passando a configuraçao do AddIdentityCore */
            builder = new IdentityBuilder(builder.UserType, typeof(Role), builder.Services);

            // configuraçoes de contextos e Roles
            builder.AddEntityFrameworkStores<ProAgilContext>();
            builder.AddRoleValidator<RoleValidator<Role>>();
            builder.AddRoleManager<RoleManager<Role>>(); // gerenciador dos papeis
            builder.AddSignInManager<SignInManager<User>>(); // quem vai controlar o cadastro de usuarios
            
            // configurando o JWT
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options => 
                    {
                         options.TokenValidationParameters = new TokenValidationParameters
                         {
                             ValidateIssuerSigningKey = true,
                             IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII
                                  .GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                             ValidateIssuer = false,
                             ValidateAudience = false
                         };
                    }
                );
                    

            // toda vez que precisar da interface, injeta ela no projeto de repository
            services.AddMvc(
                options => {
                    /* politica de autenticaçao de todas as controllers para que toda vez que 
                    for chamar uma rota, que ele esteja autenticado */
                    var policy = new AuthorizationPolicyBuilder()
                        .RequireAuthenticatedUser() // vai requerir que um usuario esteja autenticado
                        .Build();
                    options.Filters.Add(new AuthorizeFilter(policy)); // filtrar todas as chamadas da politica
                }
            ).SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
             .AddJsonOptions(opt => opt.SerializerSettings.ReferenceLoopHandling = 
             Newtonsoft.Json.ReferenceLoopHandling.Ignore); // controla a redundancia de serelizaçao de retorno dos itens

            services.AddScoped<IProAgilRepository, ProAgilRepository>();
            services.AddAutoMapper(); // vai permitir o uso do autoMappper
            services.AddCors();
            //vai permitir uma requisiçao cruzada entre a WebAPI e o Angular
        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseAuthentication(); // para ser autenticado

            //app.UseHttpsRedirection();
            //vai permitir toda origem, metodo e cabeçalho
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseStaticFiles(); //faz com que a webapi disponibiliza as imagens
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Resources")),
                RequestPath = new PathString("/Resources")
            });
            
            app.UseMvc();
            
        }
    }
}
