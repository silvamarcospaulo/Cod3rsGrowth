using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Web;
using FluentMigrator.Runner;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddProblemDetails();
builder.Services.AddSwaggerGen();

ModuloInjetor.ModuloDeInjecaoInfra.BindServices(builder.Services);

var serviceProvider = builder.Services.BuildServiceProvider();

ModuloInjetor.AtualizarBancoDeDados(serviceProvider);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseRouting();

var loggerFactory = app.Services.GetRequiredService<ILoggerFactory>();

app.UseProblemDetailsExceptionHandler(loggerFactory);

app.MapControllers();

app.Run();