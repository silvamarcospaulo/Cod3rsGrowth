using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryCarta;
using Cod3rsGrowth.Teste.Singleton;

namespace Cod3rsGrowth.Teste.Repository
{
    public class CartaRepositoryMock : ICartaRepository
    {
        public List<Carta> tabelasCartas = SingletonTabelas.InstanciaCartas;

        public void Inserir(Carta carta)
        {
            tabelasCartas.Add(carta);
        }

        public void Excluir(int idCarta)
        {
        }

        public Carta ObterPorId(int idCarta)
        {
            return idCarta < 1 ? throw new Exception("Valor Invalido") :
                tabelasCartas.FirstOrDefault(carta => carta.IdCarta == idCarta) ?? throw new Exception("Carta Nao Encontrada");
        }

        public List<Carta> ObterTodos()
        {
            return tabelasCartas;
        }
    }
}