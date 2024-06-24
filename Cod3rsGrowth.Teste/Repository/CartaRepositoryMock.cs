using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository;
using Cod3rsGrowth.Teste.Singleton;

namespace Cod3rsGrowth.Teste.Repository
{
    public class CartaRepositoryMock : ICartaRepository
    {
        private List<Carta> tabelasCartas = SingletonTabelasTeste.InstanciaCartas;

        private int GerarIdCarta()
        {
            const int ValorInicial = 1;
            const int Incremento = 1;

            var cartas = ObterTodos(null);
            var ultimoId = cartas.Any() ? cartas.Max(carta => carta.IdCarta) : ValorInicial - Incremento;

            return ultimoId + Incremento;
        }

        public void Criar(Carta carta)
        {
            carta.IdCarta = GerarIdCarta();
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

        public List<Carta> ObterTodos(CartaFiltro? filtro)
        {
            return tabelasCartas;
        }
    }
}