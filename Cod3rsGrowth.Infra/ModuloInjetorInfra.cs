using LinqToDB;
using LinqToDB.AspNet;
using LinqToDB.AspNet.Logging;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace Cod3rsGrowth.Infra
{
    public static class ModuloInjetorInfra
    {
        public static void ModuloInjetorTeste(ServiceCollection serviceProvider)
        {
            const string stringDeConexao = "contextoPadrao";

            serviceProvider.AddLinqToDBContext<ConexaoDados>((provider, options)
                => options
                .UseSqlServer(ConfigurationManager
                .ConnectionStrings[stringDeConexao].ConnectionString)
                .UseDefaultLogging(provider));
        }
    }
}