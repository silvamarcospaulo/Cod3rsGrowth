using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Servicos.ServicoJogador
{
    public interface IServicoJogador
    {
        void Inserir(Jogador jogador);
        Jogador ObterPorId(int idJogador);
        List<Jogador> ObterTodos();
        decimal SomarPrecoDeTodasAsCartasDoJogador(Jogador jogador);
        int SomarQuantidadeDeBaralhosDoJogador(Jogador jogador);
    }
}