using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Servicos.ServicoJogador
{
    public interface IServicoJogador
    {
        public decimal SomarPrecoDeTodasAsCartasDoJogador(Jogador jogador);
        public int SomarQuantidadeDeBaralhosDoJogador(Jogador jogador);
    }
}