using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository.RepositoryBaralho
{
    public interface IBaralhoRepository
    {
        bool Excluir(int idBaralho, List<Baralho> baralhos);
        Baralho ObterPorId(int idBaralho, List<Baralho> baralhos);
        List<Baralho> ObterTodos(List<Baralho> baralhos);
    }
}