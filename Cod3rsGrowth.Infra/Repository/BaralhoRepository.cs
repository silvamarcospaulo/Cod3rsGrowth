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

        public int Criar(Baralho baralho)
        {
            return conexaoDados.InsertWithInt32Identity(baralho);
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
            return conexaoDados.GetTable<Baralho>().FirstOrDefault(baralho => baralho.Id == idBaralho) ??
                throw new Exception($"Baralho {idBaralho} Nao Encontrado");
        }

        public List<Baralho> ObterTodos(BaralhoFiltro? filtro)
        {
            const int valorMinimo = 1;

            IQueryable<Baralho> query = from q in conexaoDados.TabelaBaralho
                                        select q;

            if (filtro?.IdJogador != null)
            {
                query = from q in query
                        where q.IdJogador == filtro.IdJogador
                        select q;
            }

            if (filtro?.FormatoDeJogoBaralho != null)
            {
                query = from q in query
                        where q.FormatoDeJogoBaralho == filtro.FormatoDeJogoBaralho
                        select q;
            }

            if (filtro?.PrecoDoBaralhoMinimo != null)
            {
                query = from q in query
                        where q.PrecoDoBaralho >= filtro.PrecoDoBaralhoMinimo
                        select q;
            }

            if (filtro?.PrecoDoBaralhoMaximo != null)
            {
                query = from q in query
                        where q.PrecoDoBaralho <= filtro.PrecoDoBaralhoMaximo
                        select q;
            }

            if (filtro?.CorBaralho?.Count() > valorMinimo)
            {
                query = from q in query
                        where q.CorBaralho.All(corBaralho => filtro.CorBaralho.All(cor => cor == corBaralho))
                        select q;
            }
                
            return query.ToList();
        }

        public void CriarCorBaralho(CorBaralho corBaralho)
        {
            conexaoDados.Insert(corBaralho);
        }

        public void ExcluirCorBaralho(int idCorBaralho)
        {
            conexaoDados.Delete(idCorBaralho);
        }

        public CorBaralho ObterPorIdCorBaralho(int idCorBaralho)
        {
            return conexaoDados.GetTable<CorBaralho>().FirstOrDefault(corBaralho => corBaralho.IdCorBaralho == idCorBaralho) ??
                throw new Exception($"Registro nao encontrado");
        }

        public List<CorBaralho> ObterTodosCorBaralho(CorBaralhoFiltro? filtro)
        {
            IQueryable<CorBaralho> query = from q in conexaoDados.TabelaCorBaralho
                                        select q;

            if (filtro?.idBaralho != null)
            {
                query = from q in query
                        where q.IdBaralho == filtro.idBaralho
                        select q;
            }

            return query.ToList();
        }

        public void CriarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            conexaoDados.Insert(copiaDeCartasNoBaralho);
        }

        public void AtualizarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            conexaoDados.Update(copiaDeCartasNoBaralho);
        }

        public void ExcluirCopiaDeCartas(int idCopiaDeCartasNoBaralho)
        {
            conexaoDados.Delete(ObterPorId(idCopiaDeCartasNoBaralho));
        }

        public CopiaDeCartasNoBaralho ObterPorIdCopiaDeCartas(int idCopiaDeCartasNoBaralho)
        {
            return conexaoDados.GetTable<CopiaDeCartasNoBaralho>().FirstOrDefault(copiaDeCartasNoBaralho => copiaDeCartasNoBaralho.IdCopiaDeCartasNoBaralho == idCopiaDeCartasNoBaralho) ??
                throw new Exception($"Registro Nao Encontrado");
        }

        public List<CopiaDeCartasNoBaralho> ObterTodosCopiaDeCartas(CopiaDeCartasNoBaralhoFiltro filtro)
        {
            IQueryable<CopiaDeCartasNoBaralho> query = from q in conexaoDados.TabelaCartasDoBaralho
                select q;

            if (filtro?.IdBaralho != null)
            {
                query = from q in query
                        where q.IdBaralho == filtro.IdBaralho
                        select q;
            }

            return query.ToList();
        }
    }
}