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

            if (filtro?.IdJogador is not null)
            {
                query = from q in query
                        where q.IdJogador == filtro.IdJogador
                        select q;
            }

            if (filtro?.Nome is not null)
            {
                query = from q in query
                        where q.NomeBaralho.Contains(filtro.Nome)
                        select q;
            }

            if (filtro?.FormatoDeJogoBaralho?.Count() >= valorMinimo)
            {
                foreach (var formatoDeJogo in filtro.FormatoDeJogoBaralho)
                {
                    query = from q in query
                            where q.FormatoDeJogoBaralho == formatoDeJogo
                            select q;
                }
            }

            if (filtro?.PrecoDoBaralhoMinimo is not null)
            {
                query = from q in query
                        where q.PrecoDoBaralho >= filtro.PrecoDoBaralhoMinimo
                        select q;
            }

            if (filtro?.PrecoDoBaralhoMaximo is not null)
            {
                query = from q in query
                        where q.PrecoDoBaralho <= filtro.PrecoDoBaralhoMaximo
                        select q;
            }

            if (filtro?.DataCriacaoMinimo is not null)
            {
                query = from q in query
                        where q.DataDeCriacaoBaralho >= filtro.DataCriacaoMinimo
                        select q;
            }

            if (filtro?.DataCriacaoMaximo is not null)
            {
                query = from q in query
                        where q.DataDeCriacaoBaralho <= filtro.DataCriacaoMaximo
                        select q;
            }

            if (filtro?.CorBaralho?.Count() >= valorMinimo)
            {
                foreach (var cor in filtro.CorBaralho)
                {
                    query = from q in query
                            where q.CorBaralho.Contains(cor)
                            select q;
                }
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
            return conexaoDados.GetTable<CopiaDeCartasNoBaralho>().FirstOrDefault(copiaDeCartasNoBaralho => copiaDeCartasNoBaralho.Id == idCopiaDeCartasNoBaralho) ??
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