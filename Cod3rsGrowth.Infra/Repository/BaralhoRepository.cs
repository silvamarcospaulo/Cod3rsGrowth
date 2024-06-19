using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;
using System.Data;

namespace Cod3rsGrowth.Infra.Repository
{
    public class BaralhoRepository : IBaralhoRepository
    {
        private ConexaoDados conexaoDados = new ConexaoDados();

        public void Criar(Baralho baralho)
        {
            conexaoDados.Insert(baralho);
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
            
            if (filtro == null) return conexaoDados.TabelaBaralhos.ToList();

            IQueryable<Baralho> query = conexaoDados.TabelaBaralhos.AsQueryable();

            if (filtro.FormatoDeJogoBaralho.HasValue) query = query.Where(q => q.FormatoDeJogoBaralho == filtro.FormatoDeJogoBaralho);

            if (filtro.PrecoDoBaralhoMinimo.HasValue) query = query.Where(q => q.PrecoDoBaralho >= filtro.PrecoDoBaralhoMinimo);

            if (filtro.PrecoDoBaralhoMaximo.HasValue) query = query.Where(q => q.PrecoDoBaralho >= filtro.PrecoDoBaralhoMaximo);

            if (filtro.CorBaralho != null)
            {
                foreach (var cor in filtro.CorBaralho)
                {
                    query = query.Where(q => q.CorBaralho.All(corBaralho => corBaralho == cor));
                }
            }

            return query.ToList();
        }
    }
}