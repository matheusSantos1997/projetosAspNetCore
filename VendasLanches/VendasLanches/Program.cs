using Microsoft.EntityFrameworkCore;
using VendasLanches.Context;
using VendasLanches.Ioc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LanchesContext>(options => 
   {
       string conn = builder.Configuration.GetConnectionString("DefaultConnection");
       options.UseSqlServer(conn);
   }
);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMemoryCache();
builder.Services.AddSession();

builder.Services.RegisterRepositories();
builder.Services.RegisterHttpContextAcessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "categoriaFiltro",
    pattern: "lanche/{action}/{categoria?}",
    defaults: new { controller = "Lanche", action = "List" }
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
