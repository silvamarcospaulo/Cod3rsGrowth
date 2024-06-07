using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Servicos.ServicoJogador
{
    public interface IServicoJogador
    {
        Jogador ObterPorId(int idJogador);
        List<Jogador> ObterTodos();
        void CriarJogador(Jogador jogador);
    }
}