﻿using LinqToDB;
using LinqToDB.AspNet;
using LinqToDB.AspNet.Logging;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace Cod3rsGrowth.Infra
{
    public static class ModuloInjetor
    {
        public static void ModuloInjetorInfra(ServiceCollection serviceProvider)
        {
            const string stringDeConexao = "DeckBuilderDb";

            serviceProvider.AddLinqToDBContext<ConexaoDados>((provider, options)
                => options
                .UseSqlServer(ConfigurationManager
                .ConnectionStrings[stringDeConexao].ConnectionString)
                .UseDefaultLogging(provider));
        }
    }
}