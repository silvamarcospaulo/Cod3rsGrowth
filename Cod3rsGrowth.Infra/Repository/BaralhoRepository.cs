using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;
using LinqToDB.Common;
using System.Data;
using System.Runtime.ConstrainedExecution;

namespace Cod3rsGrowth.Infra.Repository
{
    public class BaralhoRepository : IBaralhoRepository
    {
        public void Criar(Baralho baralho)
        {
            using (var conexaoDados = new ConexaoDados())
            {
                conexaoDados.Insert(baralho);
            }
        }

        public void Atualizar(Baralho baralho)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Baralho baralho)
        {
            throw new NotImplementedException();
        }

        public Baralho ObterPorId(int idBaralho)
        {
            throw new NotImplementedException();
        }

        public List<Baralho> ObterTodos(BaralhoFiltro? filtro)
        {

            using (var conexaoDados = new ConexaoDados())
            {
                IQueryable<Baralho> query = from q in conexaoDados.TabelaBaralhos
                                          select q;

                if (filtro.FormatoDeJogoBaralho != null)
                {
                    query = from q in query
                            where q.FormatoDeJogoBaralho == filtro.FormatoDeJogoBaralho
                            select q;
                }

                if (filtro.PrecoDoBaralhoMinimo != null)
                {
                    query = from q in query
                            where q.PrecoDoBaralho == filtro.PrecoDoBaralhoMinimo
                            select q;
                }

                if (filtro.PrecoDoBaralhoMaximo != null)
                {
                    query = from q in query
                            where q.PrecoDoBaralho == filtro.PrecoDoBaralhoMaximo
                            select q;
                }

                if (!filtro.CorBaralho.IsNullOrEmpty())
                {
                    query = from q in query
                            where q.CorBaralho.All(corBaralho => filtro.CorBaralho.All(cor => cor == corBaralho))
                            select q;
                }
                
                return query.ToList();
            }
        }
    }
}