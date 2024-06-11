using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryBaralho;
using Cod3rsGrowth.Infra.Repository.RepositoryCarta;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servicos.ServicoJogador;
using Cod3rsGrowth.Teste.Repository;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;


namespace Cod3rsGrowth.Teste
{
    public static class ModuloInjetor
    {
        public static void ModuloInjetorTeste(ServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<ServicoCarta>();
            serviceProvider.AddScoped<ServicoBaralho>();
            serviceProvider.AddScoped<ServicoJogador>();

            serviceProvider.AddScoped<ICartaRepository, CartaRepositoryMock>();
            serviceProvider.AddScoped<IBaralhoRepository, BaralhoRepositoryMock>();
            serviceProvider.AddScoped<IJogadorRepository, JogadorRepositoryMock>();

            serviceProvider.AddScoped<IValidator<Carta>, ValidadorCarta>();
            serviceProvider.AddScoped<IValidator<Baralho>, ValidadorBaralho>();
            serviceProvider.AddScoped<IValidator<Jogador>, ValidadorJogador>();
        }
    }
}