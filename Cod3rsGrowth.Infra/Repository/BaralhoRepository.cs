using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;
using System.Data;

namespace Cod3rsGrowth.Infra.Repository
{
    public class BaralhoRepository : IBaralhoRepository
    {
        private readonly ConexaoDados conexaoDados;

        public BaralhoRepository(ConexaoDados _conexaoDados)
        {
            conexaoDados = _conexaoDados;
        }

        public void Criar(Baralho baralho)
        {
            conexaoDados.Insert(baralho);
        }

        public void Atualizar(Baralho baralho)
        {
            conexaoDados.Update(baralho);
        }

        public void Excluir(int idBaralho)
        {
            var baralhoExcluir = ObterPorId(idBaralho);
            conexaoDados.Delete(baralhoExcluir);
        }

        public Baralho ObterPorId(int idBaralho)
        {
            return conexaoDados.GetTable<Baralho>().FirstOrDefault(baralho => baralho.IdBaralho == idBaralho) ??
                throw new Exception($"Baralho {idBaralho} Nao Encontrado");
        }

        public List<Baralho> ObterTodos(BaralhoFiltro? filtro)
        {
            const int valorMinimoListaCorCartas = 1;

            IQueryable<Baralho> query = from q in conexaoDados.TabelaBaralhos
                                        select q;

            if (filtro?.FormatoDeJogoBaralho != null)
            {
                query = from q in query
                        where q.FormatoDeJogoBaralho == filtro.FormatoDeJogoBaralho
                        select q;
            }

            if (filtro?.PrecoDoBaralhoMinimo != null)
            {
                query = from q in query
                        where q.PrecoDoBaralho == filtro.PrecoDoBaralhoMinimo
                        select q;
            }

            if (filtro?.PrecoDoBaralhoMaximo != null)
            {
                query = from q in query
                        where q.PrecoDoBaralho == filtro.PrecoDoBaralhoMaximo
                        select q;
            }

            if (filtro?.CorBaralho.Count() > valorMinimoListaCorCartas)
            {
                query = from q in query
                        where q.CorBaralho.All(corBaralho => filtro.CorBaralho.All(cor => cor == corBaralho))
                        select q;
            }
                
            return query.ToList();
        }
    }
}