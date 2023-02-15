using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GaleriaImagens.API.Injectors;
using GaleriaImagens.Repository.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;

namespace GaleriaImagens.API
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
            services.AddDbContext<DataContext>();

            services.AddControllers();
            
            services.AddControllers()
                    .AddJsonOptions(options => 
                    {
                        options.JsonSerializerOptions.IgnoreNullValues = true; // api ignora os valores nulos
                        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); 
                        // trata o retorno de enums mostrando os textos em vez das chaves
                    })
                    .AddNewtonsoftJson(options => 
                    {
                        options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; // ignora referencias circulares
                        options.SerializerSettings.DateFormatString = "dd/MM/yyyy";
                    });
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GaleriaImagens.API", Version = "v1" });
                 c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                 {
                    Description = @"Jwt Authorization using header Bearer. Exemple: 'Bearer your_token'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                 });

                 c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                 {
                     {
                         new OpenApiSecurityScheme
                         {
                             Reference = new OpenApiReference
                             {
                                 Type = ReferenceType.SecurityScheme,
                                 Id = "Bearer"
                             },
                             Scheme = "oauth2",
                             Name = "Bearer",
                             In = ParameterLocation.Header
                         },
                         new List<string>()
                     }
                 });

            });

            // configuraçao Scopeds
            RepositoryInjector.RegisterRepositories(services);

            services.AddCors();

            var key = Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Secret").Value);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var ptBR = new CultureInfo("pt-BR");

            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ptBR),
                SupportedCultures = new List<CultureInfo> { ptBR },
                SupportedUICultures = new List<CultureInfo> { ptBR }
            };

            app.UseRequestLocalization(localizationOptions);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GaleriaImagens.API v1"));
            }
            else
            {
                app.UseHttpsRedirection();
            }

            app.UseRouting();
     
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseStaticFiles(); //faz com que a webapi disponibiliza as imagens
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Images")),
                RequestPath = new PathString("/Images")
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
