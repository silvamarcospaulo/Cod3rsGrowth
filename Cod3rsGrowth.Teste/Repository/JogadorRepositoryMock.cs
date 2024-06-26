using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Teste.Singleton;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace Cod3rsGrowth.Teste.Repository
{
    public class JogadorRepositoryMock : IJogadorRepository
    {
        private List<Jogador> tabelaJogador = SingletonTabelasTeste.InstanciaJogador;
        private BaralhoServico _baralhoServico;

        public JogadorRepositoryMock(BaralhoServico baralhoServico)
        {
            _baralhoServico = baralhoServico;
        }

        private int GerarId()
        {
            const int ValorInicial = 1;
            const int Incremento = 1;

            var JogadoresBanco = ObterTodos(null);
            var ultimoId = JogadoresBanco.Any() ? JogadoresBanco.Max(jogador => jogador.IdJogador) : ValorInicial - Incremento;

            return ultimoId + Incremento;
        }

        public void Criar(Jogador jogador)
        {
            jogador.IdJogador = GerarId();
            tabelaJogador.Add(jogador);
        }

        public void Atualizar(Jogador jogador)
        {
            var jogadorBanco = ObterPorId(jogador.IdJogador);
            jogadorBanco = jogador;
        }

        public void Excluir(int idJogador)
        {
            var jogadorExcluir = ObterPorId(idJogador);
            tabelaJogador.Remove(jogadorExcluir);
        }

        public Jogador ObterPorId(int idJogador)
        {
            var jogador = tabelaJogador.FirstOrDefault(jogador => jogador.IdJogador == idJogador) ?? throw new Exception($"Jogador {idJogador} Nao Encontrado");
            jogador.BaralhosJogador = _baralhoServico.ObterTodos(new BaralhoFiltro() { IdJogador = idJogador });
            return jogador;
        }

        public List<Jogador> ObterTodos(JogadorFiltro? filtro)
        {
            IQueryable<Jogador> query = from q in tabelaJogador.AsQueryable()
                                        select q;

            if (filtro?.NomeJogador != null)
            {
                query = from q in query
                        where q.NomeJogador.Contains(filtro.NomeJogador)
                        select q;
            }

            if (filtro?.ContaAtivaJogador != null)
            {
                query = from q in query
                        where q.ContaAtivaJogador == filtro.ContaAtivaJogador
                        select q;
            }

            if (filtro?.DataNascimentoJogadorMinimo != null)
            {
                query = from q in query
                        where q.DataNascimentoJogador >= filtro.DataNascimentoJogadorMinimo
                        select q;
            }

            if (filtro?.DataNascimentoJogadorMaximo != null)
            {
                query = from q in query
                        where q.DataNascimentoJogador <= filtro.DataNascimentoJogadorMaximo
                        select q;
            }

            if (filtro?.PrecoDasCartasJogadorMinimo != null)
            {
                query = from q in query
                        where q.PrecoDasCartasJogador >= filtro.PrecoDasCartasJogadorMinimo
                        select q;
            }

            if (filtro?.DataNascimentoJogadorMaximo != null)
            {
                query = from q in query
                        where q.PrecoDasCartasJogador <= filtro.PrecoDasCartasJogadorMaximo
                        select q;
            }

            return query.ToList();
        }
    }
}