using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Dominio.Servicos
{
    public class ServicoJogador : IServicoJogador
    {
        public decimal SomarPrecoDeTodasAsCartasDoJogador(Jogador jogador)
        {
            return jogador.BaralhosJogador.SelectMany(baralhos => baralhos.CartasDoBaralho)
                .Sum(carta => carta.QuantidadeCopiasDaCartaNoBaralho * carta.Carta.PrecoCarta);
        }

        public int SomarQuantidadeDeBaralhosDoJogador(Jogador jogador)
        {
            return jogador.QuantidadeDeBaralhosJogador;
        }
    }
}