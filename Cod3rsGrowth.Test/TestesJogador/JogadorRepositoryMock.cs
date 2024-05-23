using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Cod3rsGrowth.Test.TestesCarta;

namespace Cod3rsGrowth.Test.TestesJogador
{
    public class JogadorRepositoryMock : IJogadorRepository
    {   
        public void Excluir(int idJogador)
        {
            //jogadores.Remove(ObterPorId(idJogador, jogadores));
        }

        public Jogador ObterPorId(int idJogador)
        {
            //return jogadores.FirstOrDefault(jogador => jogador.IdJogador == idJogador);
            return new Jogador();
        }

        public List<Jogador> ObterTodos()
        {
            return new List<Jogador>();
        }
    }
}