using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryCarta;

namespace Cod3rsGrowth.Test.TestesCarta
{
    public class CartaRepositoryTeste : ICartaRepository
    {
        public void Excluir(int idCarta)
        {
            //cartas.Remove(ObterPorId(idCarta, cartas));
        }

        public Carta ObterPorId(int idCarta)
        {
            return cartas.FirstOrDefault(carta => carta.IdCarta == idCarta);
        }

        public List<Carta> ObterTodos()
        {
            return Cartas;
        }
    }
}