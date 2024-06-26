using LinqToDB;
using LinqToDB.AspNet;
using LinqToDB.AspNet.Logging;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace Cod3rsGrowth.Infra
{
    public class ModuloDeInjecao
    {
        public class ModuloDeInjecaoInfra
        {
            private static string _chaveDeConexao = "DeckBuilderDb";
            public static void BindServices(ServiceCollection servicos)
            {
                servicos.AddLinqToDBContext<ConexaoDados>((provider, options) => options
                        .UseSqlServer(ConfigurationManager.ConnectionStrings[_chaveDeConexao].ConnectionString)
                        .UseDefaultLogging(provider)
                );
            }
        }
    }
}