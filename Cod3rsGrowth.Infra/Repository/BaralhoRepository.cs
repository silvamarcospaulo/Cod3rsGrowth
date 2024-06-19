using System;
using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository
{
    public class BaralhoRepository : IBaralhoRepository
    {
        public Baralho ObterPorId(int idBaralho)
        {
            throw new NotImplementedException();
        }

        public List<Baralho> ObterTodos(BaralhoFiltro? filtro)
        {
            using (var contextoBaralho = new ConexaoDados())
            {
                if (filtro == null) return contextoBaralho.TabelaBaralhos.ToList();

                IQueryable<Baralho> query = contextoBaralho.TabelaBaralhos.AsQueryable();

                if (filtro.FormatoDeJogoBaralho.HasValue) query = query.Where(q => q.FormatoDeJogoBaralho == filtro.FormatoDeJogoBaralho);

                if (filtro.PrecoDoBaralhoMinimo.HasValue) query = query.Where(q => q.PrecoDoBaralho >= filtro.PrecoDoBaralhoMinimo);

                if (filtro.PrecoDoBaralhoMaximo.HasValue) query = query.Where(q => q.PrecoDoBaralho >= filtro.PrecoDoBaralhoMaximo);

                if (filtro.CorBaralho != null) {
                    foreach (var cor in filtro.CorBaralho)
                    {
                        query = query.Where(q => q.CorBaralho.All(corBaralho => corBaralho == cor));
                    }
                }

                return query.ToList();
            };
        }

        public void Criar(Baralho baralho)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Baralho baralho)
        {
            throw new NotImplementedException();
        }
        public void Excluir(Baralho baralho)
        {
            throw new NotImplementedException();
        }
    }
}