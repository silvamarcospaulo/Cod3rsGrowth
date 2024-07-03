using LinqToDB;
using LinqToDB.AspNet;
using LinqToDB.AspNet.Logging;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

using Cod3rsGrowth.Dominio.Auth;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository;
using FluentValidation;

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
            }
        }
    }
}