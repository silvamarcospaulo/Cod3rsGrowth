using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Servico.ServicoJogador.ServicoToken;
using Cod3rsGrowth.Teste.Repository;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;


namespace Cod3rsGrowth.Teste
{
    public static class ModuloInjetor
    {
        public static void ModuloInjetorTeste(ServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<CartaServico>();
            serviceProvider.AddScoped<BaralhoServico>();
            serviceProvider.AddScoped<JogadorServico>();
            serviceProvider.AddScoped<JwtServico>();

            serviceProvider.AddScoped<ICartaRepository, CartaRepositoryMock>();
            serviceProvider.AddScoped<IBaralhoRepository, BaralhoRepositoryMock>();
            serviceProvider.AddScoped<IJogadorRepository, JogadorRepositoryMock>();

            serviceProvider.AddScoped<IValidator<Carta>, CartaValidador>();
            serviceProvider.AddScoped<IValidator<Baralho>, BaralhoValidador>();
            serviceProvider.AddScoped<IValidator<Jogador>, JogadorValidador>();
        }
    }
}