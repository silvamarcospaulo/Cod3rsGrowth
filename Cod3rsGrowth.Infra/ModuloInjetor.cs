using Cod3rsGrowth.Dominio.Auth;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Migrador;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoAuth;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using FluentMigrator.Runner;
using FluentValidation;
using LinqToDB;
using LinqToDB.AspNet;
using LinqToDB.AspNet.Logging;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Text;

namespace Cod3rsGrowth.Infra
{
    public class ModuloInjetor
    {
        public class ModuloDeInjecaoInfra
        {
            private static string _chaveDeConexao = "DeckBuilderDb";

            public static void BindServices(IServiceCollection servicos)
            {
                var chave = Encoding.ASCII.GetBytes(ConfiguracaoChave.Segredo);
                servicos
                    .AddScoped<ICartaRepository, CartaRepository>()
                    .AddScoped<IBaralhoRepository, BaralhoRepository>()
                    .AddScoped<IJogadorRepository, JogadorRepository>()
                    .AddScoped<CartaServico>()
                    .AddScoped<BaralhoServico>()
                    .AddScoped<JogadorServico>()
                    .AddScoped<JwtServico>()
                    .AddScoped<HashServico>()
                    .AddScoped<IValidator<Carta>, CartaValidador>()
                    .AddScoped<IValidator<Baralho>, BaralhoValidador>()
                    .AddScoped<IValidator<Jogador>, JogadorValidador>()
                    .AddLinqToDBContext<ConexaoDados>((provider, options) => options
                        .UseSqlServer(ConfigurationManager.ConnectionStrings[_chaveDeConexao].ConnectionString)
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

                servicos.AddFluentMigratorCore()
                    .ConfigureRunner(rb => rb
                        .AddSqlServer()
                        .WithGlobalConnectionString(_chaveDeConexao)
                        .ScanIn(typeof(_20240621105800_Carta).Assembly).For.Migrations())
                    .AddLogging(lb => lb.AddFluentMigratorConsole());
            }
        }

        public static void AtualizarBancoDeDados(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }
    }
}