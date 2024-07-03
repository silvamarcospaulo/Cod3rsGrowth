using Cod3rsGrowth.Dominio.Auth;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Migrador;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Infra.Repository;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Web.Controllers;
using FluentMigrator.Runner;
using FluentValidation;
using LinqToDB;
using LinqToDB.AspNet;
using LinqToDB.AspNet.Logging;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Text;

namespace Cod3rsGrowth.Forms
{
    class Program
    {
        private static string _stringDeConexao = "DeckBuilderDb";
        private static byte[] chave = Encoding.ASCII.GetBytes(ConfiguracaoChave.Segredo);

        [STAThread]
        static void Main(string[] args)
        {
            using (var serviceProvider = CreateServices())
            using (var scope = serviceProvider.CreateScope())
            {
                UpdateDatabase(scope.ServiceProvider);
            }

            var host = CreateHostBuilder().Build();
            var ServiceProvider = host.Services;
            ApplicationConfiguration.Initialize();

            Application.Run(new FormsJogadorEntrar(
                ServiceProvider.GetRequiredService<CartaServico>(),
                ServiceProvider.GetRequiredService<BaralhoServico>(),
                ServiceProvider.GetRequiredService<JogadorServico>(),
                ServiceProvider.GetRequiredService<ConexaoDados>(),
                ServiceProvider.GetRequiredService<LoginController>()
            ));
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services
                    .AddScoped<CartaServico>()
                    .AddScoped<BaralhoServico>()
                    .AddScoped<JogadorServico>()
                    .AddScoped<ICartaRepository, CartaRepository>()
                    .AddScoped<IBaralhoRepository, BaralhoRepository>()
                    .AddScoped<IJogadorRepository, JogadorRepository>()
                    .AddScoped<IValidator<Carta>, CartaValidador>()
                    .AddScoped<IValidator<Baralho>, BaralhoValidador>()
                    .AddScoped<IValidator<Jogador>, JogadorValidador>()
                    .AddLinqToDBContext<ConexaoDados>((provider, options)
                        => options
                        .UseSqlServer(ConfigurationManager
                        .ConnectionStrings[_stringDeConexao].ConnectionString)
                        .UseDefaultLogging(provider))
                    .AddAuthentication(x =>
                    {
                        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    })
                    .AddJwtBearer(x =>
                    {
                        x.RequireHttpsMetadata = false;
                        x.SaveToken = true;
                        x.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuerSigningKey = true,
                            IssuerSigningKey = new SymmetricSecurityKey(chave),
                            ValidateIssuer = false,
                            ValidateAudience = false
                        };
                    });
                });
        }

        private static ServiceProvider CreateServices()
        {
            string stringDeConexao = ConfigurationManager.ConnectionStrings[_stringDeConexao].ConnectionString;
            var colecao = new ServiceCollection();

            colecao.AddLinqToDBContext<ConexaoDados>((provider, options)
                        => options
                        .UseSqlServer(ConfigurationManager
                        .ConnectionStrings[_stringDeConexao].ConnectionString)
                        .UseDefaultLogging(provider));
            colecao.AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(stringDeConexao)
                    .ScanIn(typeof(_20240621105800_Carta).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole());

            colecao.AddCors();
            colecao.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            colecao.AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(chave),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

            return colecao.BuildServiceProvider(false);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();

            app.UseMvc();
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }
    }
}