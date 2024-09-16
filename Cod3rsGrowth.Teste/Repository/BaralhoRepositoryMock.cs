using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Teste.Singleton;

namespace Cod3rsGrowth.Teste.Repository
{
    public class BaralhoRepositoryMock : IBaralhoRepository
    {
        private List<Baralho> tabelaBaralho = SingletonTabelasTeste.InstanciaBaralho;
        private List<CopiaDeCartasNoBaralho> tabelaCopiaDeCartasNoBaralho = SingletonTabelasTeste.InstanciaCopiaDeCartasNoBaralho;
        private const int VALOR_NULO = 0;
        private const int VALOR_INICIAL = 1;
        private const int INCREMENTO = 1;

        private int GerarIdBaralho()
        {
            var baralhoBanco = ObterTodos(null);
            var ultimoId = baralhoBanco.Any() ? baralhoBanco.Max(baralho => baralho.Id) : VALOR_INICIAL - INCREMENTO;

            return ultimoId + INCREMENTO;
        }

        private int GerarIdCopiaDeCartas()
        {
            var copiaDeCartasBanco = ObterTodosCopiaDeCartas(new CopiaDeCartasNoBaralhoFiltro());
            var ultimoId = copiaDeCartasBanco.Any() ? copiaDeCartasBanco.Max(copiaDeCarta => copiaDeCarta.Id) : VALOR_INICIAL - INCREMENTO;

            return ultimoId + INCREMENTO;
        }

        public int Criar(Baralho baralho)
        {
            baralho.Id = GerarIdBaralho();
            tabelaBaralho.Add(baralho);

            return baralho.Id;
        }

        public void Atualizar(Baralho baralho)
        {
            var baralhoBanco = ObterPorId(baralho.Id);
            baralhoBanco = baralho;
        }

        public void Excluir(int idBaralho)
        {
            var baralhoExcluir = ObterPorId(idBaralho);
            tabelaBaralho.Remove(baralhoExcluir);
        }

        public Baralho ObterPorId(int idBaralho)
        {
            return tabelaBaralho.FirstOrDefault(baralho => baralho.Id == idBaralho) ?? throw new Exception($"Baralho {idBaralho} Nao Encontrado");
        }

        public List<Baralho> ObterTodos(BaralhoFiltro? filtro)
        {
            IQueryable<Baralho> query = from q in tabelaBaralho.AsQueryable()
                                        select q;

            if (filtro?.IdJogador is not null)
            {
                query = from q in query
                        where q.IdJogador == filtro.IdJogador
                        select q;
            }

            if (filtro?.NomeBaralho is not null)
            {
                query = from q in query
                        where q.NomeBaralho.Contains(filtro.NomeBaralho)
                        select q;
            }

            if (filtro?.FormatoDeJogoBaralho?.Count() >= VALOR_NULO)
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

            if (filtro?.CorBaralho?.Count() >= VALOR_NULO)
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
            copiaDeCartasNoBaralho.Id = GerarIdCopiaDeCartas();
            tabelaCopiaDeCartasNoBaralho.Add(copiaDeCartasNoBaralho);
        }

        public void AtualizarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            var copiaDeCartasNoBarahoAtualizar = ObterPorIdCopiaDeCartas(copiaDeCartasNoBaralho.Id);
            copiaDeCartasNoBarahoAtualizar = copiaDeCartasNoBaralho;
        }

        public void ExcluirCopiaDeCartas(int idCopiaDeCartasNoBaralho)
        {
            var copiaDeCartasNoBaralhoExcluir = ObterPorIdCopiaDeCartas(idCopiaDeCartasNoBaralho);
            tabelaCopiaDeCartasNoBaralho.Remove(copiaDeCartasNoBaralhoExcluir);
        }

        public CopiaDeCartasNoBaralho ObterPorIdCopiaDeCartas(int idCopiaDeCartasNoBaralho)
        {
            return tabelaCopiaDeCartasNoBaralho.FirstOrDefault(corBaralho => corBaralho.Id == idCopiaDeCartasNoBaralho) ??
                throw new Exception($"Registro nao encontrado");
        }

        public List<CopiaDeCartasNoBaralho> ObterTodosCopiaDeCartas(CopiaDeCartasNoBaralhoFiltro filtro)
        {
            IQueryable<CopiaDeCartasNoBaralho> query = from q in tabelaCopiaDeCartasNoBaralho.AsQueryable()
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