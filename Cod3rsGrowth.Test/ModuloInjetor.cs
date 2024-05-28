using Cod3rsGrowth.Infra.Repository.RepositoryBaralho;
using Cod3rsGrowth.Infra.Repository.RepositoryCarta;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Cod3rsGrowth.Test.TestesBaralho;
using Cod3rsGrowth.Test.TestesCarta;
using Cod3rsGrowth.Test.TestesJogador;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Test
{
    public static class ModuloInjetor
    {
        public static void ModuloInjetorTeste(ServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<ICartaRepository, CartaRepositoryMock>();
            serviceProvider.AddScoped<IBaralhoRepository, BaralhoRepositoryMock>();
            serviceProvider.AddScoped<IJogadorRepository, JogadorRepositoryMock>();
        }
    }
}