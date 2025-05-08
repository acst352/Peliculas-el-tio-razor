using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorMovies.Data;
var builder = WebApplication.CreateBuilder(args);

//Insercción de dependencias o servicios en el contenedor de servicios
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RazorMoviesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RazorMoviesContext") ?? throw new InvalidOperationException("Connection string 'RazorMoviesContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();