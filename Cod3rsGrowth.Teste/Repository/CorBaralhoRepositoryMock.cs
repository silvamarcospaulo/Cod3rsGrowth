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
    public class CorBaralhoRepositoryMock : ICorBaralhoRepository
    {
        private List<CorBaralho> tabelaCorBaralho = SingletonTabelasTeste.InstanciaCorBaralho;

        private int GerarId()
        {
            const int ValorInicial = 1;
            const int Incremento = 1;

            var corBaralhoBanco = ObterTodos(null);
            var ultimoId = corBaralhoBanco.Any() ? corBaralhoBanco.Max(corBaralho => corBaralho.IdCorBaralho) : ValorInicial - Incremento;

            return ultimoId + Incremento;
        }

        public void Criar(CorBaralho corBaralho)
        {
            corBaralho.IdCorBaralho = GerarId();
            tabelaCorBaralho.Add(corBaralho);
        }

        public void Excluir(int idCorBaralho)
        {
            var cartaExcluir = ObterPorId(idCorBaralho);
            tabelaCorBaralho.Remove(cartaExcluir);
        }

        public CorBaralho ObterPorId(int idCorBaralho)
        {
            return tabelaCorBaralho.FirstOrDefault(corBaralho => corBaralho.IdCorBaralho == idCorBaralho) ??
                throw new Exception($"Registro nao encontrado");
        }

        public List<CorBaralho> ObterTodos(CorBaralhoFiltro? filtro)
        {
            if (filtro?.idBaralho != null) return tabelaCorBaralho.FindAll(corBaralho => corBaralho.IdBaralho == filtro?.idBaralho);
            return tabelaCorBaralho;
        }
    }
}