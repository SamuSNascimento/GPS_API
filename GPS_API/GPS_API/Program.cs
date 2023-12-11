using Core.Interfaces;
using Infraestrutura.DataBaseContext;
using Infraestrutura.Repositories;
using Infraestrutura.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContextFactory<ApplicationDbContext>();
builder.Services.AddDbContext<ApplicationDbContext>();

builder.Services.AddScoped<IUsuarioRepositorySQL, UsuarioReporsitorySQL>();
builder.Services.AddScoped<IFolhaDePagamentoReposutorySQL, FolhaDePagamentoRepositorySQL>();
builder.Services.AddScoped<IRegistroPontoRepositorySQL, RegistroPontoRepositorySQL>();
builder.Services.AddScoped<IFeriasRepositorySQL, FeriasRepositorySQL>();
builder.Services.AddScoped<IFeriasService, FeriasService>();
builder.Services.AddScoped<IRegistroPontoService, RegistroPontoService>();
builder.Services.AddScoped<IFolhaDePagamentoService, FolhaDePagamentoService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowAnyOrigin();
            //.SetIsOriginAllowed(origin => true)
            //.AllowCredentials();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
