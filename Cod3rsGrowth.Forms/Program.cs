using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using FluentValidation;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Infra.Repository;
using Cod3rsGrowth.Infra;
using LinqToDB.AspNet;
using LinqToDB;
using LinqToDB.AspNet.Logging;

namespace Cod3rsGrowth.Forms
{
    class Program
    {
        const string chaveDeConexao = "DeckBuilderDb";
        static void Main(string[] args)
        {
            using (var serviceProvider = CreateServices())
            using (var scope = serviceProvider.CreateScope())
            {
                UpdateDatabase(scope.ServiceProvider);
            }
        }

        private static ServiceProvider CreateServices()
        {
            string stringDeConexao = ConfigurationManager.ConnectionStrings[chaveDeConexao].ToString();

            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(stringDeConexao)
                    .ScanIn(typeof().Assembly).For.Migrations())
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
                        .ConnectionStrings[chaveDeConexao].ConnectionString)
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