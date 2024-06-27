using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Migrador;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Infra.Repository;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using FluentMigrator.Runner;
using FluentValidation;
using LinqToDB;
using LinqToDB.AspNet;
using LinqToDB.AspNet.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;

namespace Cod3rsGrowth.Forms
{
    class Program
    {
        private static string _stringDeConexao = "DeckBuilderDb";

        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            var ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<CartaServico>()
                    .AddScoped<CartaServico>()
                    .AddScoped<BaralhoServico>()
                    .AddScoped<JogadorServico>()
                    .AddScoped<ICartaRepository, CartaRepository>()
                    .AddScoped<IBaralhoRepository, BaralhoRepository>()
                    .AddScoped<IJogadorRepository, JogadorRepository>()
                    .AddScoped<IValidator<Carta>, CartaValidador>()
                    .AddScoped<IValidator<Baralho>, BaralhoValidador>()
                    .AddScoped<IValidator<Jogador>, JogadorValidador>()
                    .AddScoped<Form1>();
                });
        }

        private static ServiceProvider CreateServices()
        {
            string stringDeConexao = ConfigurationManager.ConnectionStrings[_stringDeConexao].ConnectionString;

            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(stringDeConexao)
                    .ScanIn(typeof(_20240621105800).Assembly).For.Migrations())
                    .AddLinqToDBContext<ConexaoDados>((provider, options)
                        => options
                        .UseSqlServer(ConfigurationManager
                        .ConnectionStrings[_stringDeConexao].ConnectionString)
                        .UseDefaultLogging(provider))
                .AddLogging(lb => lb.AddFluentMigratorConsole())

                .BuildServiceProvider(false);
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }
    }
}