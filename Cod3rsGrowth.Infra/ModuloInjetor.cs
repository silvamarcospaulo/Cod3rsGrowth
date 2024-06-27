using LinqToDB;
using LinqToDB.AspNet;
using LinqToDB.AspNet.Logging;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Infra
{
    public class ModuloInjetor
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