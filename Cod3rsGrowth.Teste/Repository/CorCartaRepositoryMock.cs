using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Teste.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Teste.Repository
{
    public class CorCartaRepositoryMock : ICorCartaRepository
    {
        private List<CorCarta> tabelasCorCartas = SingletonTabelasTeste.InstanciaCorCarta;
        private int GerarIdCorCarta()
        {
            const int ValorInicial = 1;
            const int Incremento = 1;

            var CoresCarta = tabelasCorCartas;
            var ultimoId = CoresCarta.Any() ? CoresCarta.Max(corCarta => corCarta.IdCarta) : ValorInicial - Incremento;

            return ultimoId + Incremento;
        }

        public void Criar(CorCarta corCarta)
        {
            corCarta.IdCorCarta = GerarIdCorCarta();
            tabelasCorCartas.Add(corCarta);
        }

        public List<CorCarta> ObterTodos(CorCartaFiltro? filtro)
        {
            if (filtro?.idCarta != null) return tabelasCorCartas.FindAll(corCarta => corCarta.IdCarta == filtro.idCarta);
            return tabelasCorCartas;
        }
    }
}