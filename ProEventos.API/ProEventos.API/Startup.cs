using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProEventos.Application;
using ProEventos.Application.interfaces;
using ProEventos.Persistence;
using ProEventos.Persistence.context;
using ProEventos.Persistence.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API
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
            services.AddDbContext<ProEventosContext>(
               x => x.UseSqlite(Configuration.GetConnectionString("DefaultConnection")) // conexao com o sqlite
            );
            services.AddControllers()
                    .AddNewtonsoftJson(
                        x => x.SerializerSettings.ReferenceLoopHandling = 
                          Newtonsoft.Json.ReferenceLoopHandling.Ignore 
                     ); // ignora loopHandling(loop infinito) quando tem multiplos relacionamentos na hora que for atualizar

            // dependency injection - interface injection in class
            services.AddScoped<IEventoService, EventoService>(); 
            services.AddScoped<IGeralPersistence, GeralPersistence>();
            services.AddScoped<IEventoPersistence, EventoPersistence>();

            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
