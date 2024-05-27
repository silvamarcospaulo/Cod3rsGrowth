using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Dominio.Servicos
{
    public interface IServicoJogador
    {
        public decimal SomarPrecoDeTodasAsCartasDoJogador(Jogador jogador);
        public int SomarQuantidadeDeBaralhosDoJogador(Jogador jogador);
    }
}