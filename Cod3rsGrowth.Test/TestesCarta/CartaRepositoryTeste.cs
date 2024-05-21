using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryCarta;

namespace Cod3rsGrowth.Test.TestesCarta
{
    public class CartaRepositoryTeste : ICartaRepository
    {
        public bool Excluir(int idCarta, List<Carta> cartas)
        {
            return cartas.Remove(ObterPorId(idCarta, cartas));
        }

        public Carta ObterPorId(int idCarta, List<Carta> cartas)
        {
            return cartas.FirstOrDefault(carta => carta.IdCarta == idCarta);
        }

        public List<Carta> ObterTodos(List<Carta> Cartas)
        {
            return Cartas;
        }
    }
}