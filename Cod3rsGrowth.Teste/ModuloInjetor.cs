using Cod3rsGrowth.Infra.Repository.RepositoryBaralho;
using Cod3rsGrowth.Infra.Repository.RepositoryCarta;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Cod3rsGrowth.Teste.TestesBaralho;
using Cod3rsGrowth.Teste.TestesCarta;
using Cod3rsGrowth.Teste.TestesJogador;
using Microsoft.Extensions.DependencyInjection;


namespace Cod3rsGrowth.Teste
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