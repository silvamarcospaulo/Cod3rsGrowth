using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository;
using Cod3rsGrowth.Teste.Singleton;

namespace Cod3rsGrowth.Teste.Repository
{
    public class CartaRepositoryMock : ICartaRepository
    {
        private List<Carta> tabelaCarta = SingletonTabelasTeste.InstanciaCarta;
        private List<CorCarta> tabelaCorCarta = SingletonTabelasTeste.InstanciaCorCarta;

        private int GerarIdCarta()
        {
            const int ValorInicial = 1;
            const int Incremento = 1;

            var cartas = ObterTodos(null);
            var ultimoId = cartas.Any() ? cartas.Max(carta => carta.IdCarta) : ValorInicial - Incremento;

            return ultimoId + Incremento;
        }

        private int GerarIdCorCarta()
        {
            const int ValorInicial = 1;
            const int Incremento = 1;

            var CoresCarta = tabelaCorCarta;
            var ultimoId = CoresCarta.Any() ? CoresCarta.Max(corCarta => corCarta.IdCarta) : ValorInicial - Incremento;

            return ultimoId + Incremento;
        }

        public int Criar(Carta carta)
        {
            carta.IdCarta = GerarIdCarta();
            tabelaCarta.Add(carta);

            return carta.IdCarta;
        }

        public void Atualizar(Carta carta)
        {
            var cartaBanco = ObterPorId(carta.IdCarta);
            cartaBanco.RaridadeCarta = carta.RaridadeCarta;
            cartaBanco.PrecoCarta = carta.PrecoCarta;
        }

        public Carta ObterPorId(int idCarta)
        {
            return tabelaCarta.FirstOrDefault(carta => carta.IdCarta == idCarta) ?? throw new Exception($"Carta {idCarta} Nao Encontrada");
        }

        public List<Carta> ObterTodos(CartaFiltro? filtro)
        {
            return tabelaCarta;
        }

        public void CriarCorCarta(CorCarta corCarta)
        {
            corCarta.IdCorCarta = GerarIdCorCarta();
            tabelaCorCarta.Add(corCarta);
        }

        public List<CorCarta> ObterTodosCorCarta(CorCartaFiltro? filtro)
        {
            if (filtro?.idCarta != null) return tabelaCorCarta.FindAll(corCarta => corCarta.IdCarta == filtro.idCarta);
            return tabelaCorCarta;
        }
    }
}