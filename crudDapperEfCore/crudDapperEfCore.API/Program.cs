using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using crudDapperEfCore.API.Context;
using crudDapperEfCore.API.DTOs.Validations;
using crudDapperEfCore.API.Ioc;
using FluentValidation;
using FluentValidation.AspNetCore;
using Newtonsoft.Json.Serialization;
using OfficeOpenXml;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddFluentValidationAutoValidation() // Validação automática
                .AddFluentValidationClientsideAdapters(); // Adaptação para validação no lado do cliente (opcional)

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<DataContext>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.RegisterRepositories();
builder.Services.RegisterServices();
builder.Services.RegisterFluentValidations();

builder.Services.AddMvc().AddJsonOptions(options => {
    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    // trata o retorno de enums mostrando os textos em vez das chaves
}).AddNewtonsoftJson(options => 
{
   options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
   options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; // ignora referencias circulares
});

// configuracao ExcelPackage
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
