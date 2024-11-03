using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configura o pipeline de solicitações HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Permite servir arquivos estáticos da pasta wwwroot
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

// Define o endpoint padrão
app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run();
