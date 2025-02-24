using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.VisualBasic;
using Store;
using Store.Memory;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddMvc(option => option.EnableEndpointRouting = false);
builder.Services.AddScoped<IBookRepository, BookRepository>();

var app = builder.Build();

var someService = app.Services.GetService<IServiceCollection>();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
