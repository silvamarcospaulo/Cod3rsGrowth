using Cod3rsGrowth.Dominio.Servicos;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Test
{
    public static class ModuloInjetor
    {
        public static void ModuloInjetorTeste(IServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<IServicoCarta, ServicoCarta>();
            serviceProvider.AddScoped<IServicoBaralho, ServicoBaralho>();
            serviceProvider.AddScoped<IServicoJogador, ServicoJogador>();
        }
    }
}