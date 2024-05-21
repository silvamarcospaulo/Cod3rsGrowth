using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository.RepositoryJogador
{
    public interface IJogadorRepository
    {
        public bool Excluir(int idJogador, List<Jogador> jogadores);

        public Jogador ObterPorId(int idJogador, List<Jogador> jogadores);

        public List<Jogador> ObterTodos(List<Jogador> jogadores);
    }
}