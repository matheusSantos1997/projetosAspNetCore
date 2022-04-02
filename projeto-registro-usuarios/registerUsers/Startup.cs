using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using registerUsers.core;
using registerUsers.Data;
using registerUsers.Interfaces;
using registerUsers.Repositories;
using registerUsers.Services;

namespace registerUsers
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
          /*  string conn = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<UsuarioContext>(x =>
            {
                x.UseMySql(conn);
            }); */
            services.AddDbContext<UsuarioContext>();
            services.AddControllers()
                    .AddJsonOptions(options =>
                    {
                        options.JsonSerializerOptions.IgnoreNullValues = true; // api ignora os valores nulos
                    })
                    .AddNewtonsoftJson(options =>
                    {
                        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; // ignora referencias circulares
                    });

            services.AddCors();

            RepositoryInjector.RegisterRepositories(services);

            services.AddSwaggerGen(s => 
            {
                s.SwaggerDoc("v1", new OpenApiInfo { Title = "Usuarios", Version = "v1", });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(s => 
            {
                s.RoutePrefix = string.Empty;
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }
    }
}
