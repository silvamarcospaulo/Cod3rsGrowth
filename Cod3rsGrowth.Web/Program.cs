using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Web;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddProblemDetails();
builder.Services.AddDirectoryBrowser();

ModuloInjetor.InjecaoDeDependencia(builder.Services, builder.Environment.EnvironmentName);

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

app.Use(async (context, next) =>
{
    if (context.Request.Path.StartsWithSegments("/i18n"))
    {
        var filePath = Path.Combine(builder.Environment.ContentRootPath, "wwwroot/app/i18n", context.Request.Path.Value.Substring(6));
        if (File.Exists(filePath))
        {
            await context.Response.SendFileAsync(filePath);
            return;
        }
    }

    await next();
});

app.UseFileServer(new FileServerOptions
{
    FileProvider = new PhysicalFileProvider(
            Path.Combine(builder.Environment.ContentRootPath, "wwwroot/app/"))
});

app.Run();