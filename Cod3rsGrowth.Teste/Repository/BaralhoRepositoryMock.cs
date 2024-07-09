using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Teste.Singleton;
using System;

namespace Cod3rsGrowth.Teste.Repository
{
    public class BaralhoRepositoryMock : IBaralhoRepository
    {
        private List<Baralho> tabelaBaralho = SingletonTabelasTeste.InstanciaBaralho;
        private List<CopiaDeCartasNoBaralho> tabelaCopiaDeCartasNoBaralho = SingletonTabelasTeste.InstanciaCopiaDeCartasNoBaralho;

        private int GerarIdBaralho()
        {
            const int ValorInicial = 1;
            const int Incremento = 1;

            var baralhoBanco = ObterTodos(null);
            var ultimoId = baralhoBanco.Any() ? baralhoBanco.Max(baralho => baralho.Id) : ValorInicial - Incremento;

            return ultimoId + Incremento;
        }

        private int GerarIdCopiaDeCartas()
        {
            const int ValorInicial = 1;
            const int Incremento = 1;

            var copiaDeCartasBanco = ObterTodosCopiaDeCartas(new CopiaDeCartasNoBaralhoFiltro());
            var ultimoId = copiaDeCartasBanco.Any() ? copiaDeCartasBanco.Max(corBaralho => corBaralho.IdCopiaDeCartasNoBaralho) : ValorInicial - Incremento;

            return ultimoId + Incremento;
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
            const int valorMinimo = 0;

            IQueryable<Baralho> query = from q in tabelaBaralho.AsQueryable()
                select q;

            if (filtro?.IdJogador != null)
            {
                query = from q in query
                        where q.IdJogador == filtro.IdJogador
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
            copiaDeCartasNoBaralho.IdCopiaDeCartasNoBaralho = GerarIdCopiaDeCartas();
            tabelaCopiaDeCartasNoBaralho.Add(copiaDeCartasNoBaralho);
        }

        public void AtualizarCopiaDeCartas(CopiaDeCartasNoBaralho copiaDeCartasNoBaralho)
        {
            var copiaDeCartasNoBarahoAtualizar = ObterPorIdCopiaDeCartas(copiaDeCartasNoBaralho.IdCopiaDeCartasNoBaralho);
            copiaDeCartasNoBarahoAtualizar = copiaDeCartasNoBaralho;
        }

        public void ExcluirCopiaDeCartas(int idCopiaDeCartasNoBaralho)
        {
            var copiaDeCartasNoBaralhoExcluir = ObterPorIdCopiaDeCartas(idCopiaDeCartasNoBaralho);
            tabelaCopiaDeCartasNoBaralho.Remove(copiaDeCartasNoBaralhoExcluir);
        }

        public CopiaDeCartasNoBaralho ObterPorIdCopiaDeCartas(int idCopiaDeCartasNoBaralho)
        {
            return tabelaCopiaDeCartasNoBaralho.FirstOrDefault(corBaralho => corBaralho.IdCopiaDeCartasNoBaralho == idCopiaDeCartasNoBaralho) ??
                throw new Exception($"Registro nao encontrado");
        }

        public List<CopiaDeCartasNoBaralho> ObterTodosCopiaDeCartas(CopiaDeCartasNoBaralhoFiltro filtro)
        {
            if (filtro?.IdBaralho != null) return tabelaCopiaDeCartasNoBaralho.FindAll(copiaDeCartasNoBaralho => copiaDeCartasNoBaralho.IdBaralho == filtro.IdBaralho);
            return tabelaCopiaDeCartasNoBaralho;
        }
    }
}