using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;

namespace Cod3rsGrowth.Test.TestesJogador
{
    internal class JogadorRepositoryTeste : IJogadorRepository
    {
        public bool Excluir(int idJogador, List<Jogador> jogadores)
        {
            return jogadores.Remove(ObterPorId(idJogador, jogadores));
        }

        public Jogador ObterPorId(int idJogador, List<Jogador> jogadores)
        {
            return jogadores.FirstOrDefault(jogador => jogador.IdJogador == idJogador);
        }

        public List<Jogador> ObterTodos(List<Jogador> jogadores)
        {
            return jogadores;
        }
    }
}
