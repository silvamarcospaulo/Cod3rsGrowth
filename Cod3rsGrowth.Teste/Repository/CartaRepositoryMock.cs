using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Teste.Singleton;

namespace Cod3rsGrowth.Teste.Repository
{
    public class CartaRepositoryMock : ICartaRepository
    {
        public List<Carta> tabelasCartas = SingletonTabelas.InstanciaCartas;

        public void Criar(Carta carta)
        {
            tabelasCartas.Add(carta);
        }

        public void Atualizar(Carta carta)
        {
            var cartaBanco = ObterPorId(carta.IdCarta);
            cartaBanco.RaridadeCarta = carta.RaridadeCarta;
            cartaBanco.PrecoCarta = carta.PrecoCarta;
        }

        public Carta ObterPorId(int idCarta)
        {
            return tabelasCartas.FirstOrDefault(carta => carta.IdCarta == idCarta) ?? throw new Exception($"Carta {idCarta} Nao Encontrada");
        }

        public List<Carta> ObterTodos()
        {
            return tabelasCartas;
        }
    }
}