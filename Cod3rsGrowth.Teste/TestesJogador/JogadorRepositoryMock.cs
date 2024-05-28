using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;

namespace Cod3rsGrowth.Teste.TestesJogador
{
    public class JogadorRepositoryMock : IJogadorRepository
    {   
        public void Excluir(int idJogador)
        {
        }

        public Jogador ObterPorId(int idJogador)
        {
            return new Jogador();
        }

        public List<Jogador> ObterTodos()
        {
            return new List<Jogador>();
        }
    }
}