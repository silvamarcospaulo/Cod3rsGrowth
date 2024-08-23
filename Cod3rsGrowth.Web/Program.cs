using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddProblemDetails();
builder.Services.AddDirectoryBrowser();

ModuloInjetor.ModuloDeInjecaoInfra.BindServices(builder.Services);

var serviceProvider = builder.Services.BuildServiceProvider();

ModuloInjetor.AtualizarBancoDeDados(serviceProvider);

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseRouting();

var loggerFactory = app.Services.GetRequiredService<ILoggerFactory>();

app.UseProblemDetailsExceptionHandler(loggerFactory);

app.MapControllers();

app.UseFileServer(new FileServerOptions()
{
    EnableDirectoryBrowsing = true
});
app.UseStaticFiles(new StaticFileOptions()
{
    ServeUnknownFileTypes = true
});

app.Run();