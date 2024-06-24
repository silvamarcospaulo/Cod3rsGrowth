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
    public class CopiaDeCartasNoBaralhoRepositoryMock : ICopiaDeCartasNoBaralhoRepository
    {
        private List<CopiaDeCartasNoBaralho> tabelaCopiaDeCartas = SingletonTabelasTeste.InstanciaCopiaDeCartasNoBaralho;
        public void Criar(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            tabelaCopiaDeCartas.Add(copiaDeCartasNoBaralho);
        }

        public void Atualizar(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            var copiaDeCartasNoBarahoAtualizar = ObterPorId(copiaDeCartasNoBaralho.IdCopiaDeCartasNoBaralho);
            copiaDeCartasNoBarahoAtualizar = copiaDeCartasNoBaralho;
        }

        public void Excluir(int IdCopiaDeCartasNoBaralho)
        {
            var copiaDeCartasNoBaralho = ObterPorId(IdCopiaDeCartasNoBaralho);
            tabelaCopiaDeCartas.Remove(copiaDeCartasNoBaralho);
        }

        public CopiaDeCartasNoBaralho ObterPorId(int idCopiaDeCartasNoBaralho)
        {
            return tabelaCopiaDeCartas.FirstOrDefault(copiaDeCartasNoBaralho => copiaDeCartasNoBaralho.IdCopiaDeCartasNoBaralho == idCopiaDeCartasNoBaralho) ??
                throw new Exception($"Carta {idCopiaDeCartasNoBaralho} Nao Encontrada no Baralho");
        }

        public List<CopiaDeCartasNoBaralho> ObterTodos(CopiaDeCartasNoBaralhoFiltro filtro)
        {
            var cartasDoBaralho = tabelaCopiaDeCartas.FindAll(copiaDeCartas => copiaDeCartas.IdBaralho == filtro.IdBaralho);
            cartasDoBaralho
            return cartasDoBaralho;
        }
    }
}