using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;
using System;

namespace Cod3rsGrowth.Infra.Repository
{
    public class JogadorRepository : IJogadorRepository
    {
        private readonly ConexaoDados conexaoDados = new();

        public void Criar(Jogador jogador)
        {
            conexaoDados.Insert(jogador);
        }

        public void Atualizar(Jogador jogador)
        {
            conexaoDados.Update(jogador);
        }

        public void Excluir(Jogador jogador)
        {
            conexaoDados.Delete(jogador);
        }

        public Jogador ObterPorId(int idJogador)
        {
            throw new NotImplementedException();
        }

        public List<Jogador> ObterTodos(JogadorFiltro? filtro)
        {
            IQueryable<Jogador> query = from q in conexaoDados.TabelaJogadores
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

            if (filtro?.QuantidadeDeBaralhosJogadorMinimo != null)
            {
                query = from q in query
                        where q.QuantidadeDeBaralhosJogador >= filtro.QuantidadeDeBaralhosJogadorMinimo
                        select q;
            }

            if (filtro?.QuantidadeDeBaralhosJogadorMaximo != null)
            {
                query = from q in query
                        where q.QuantidadeDeBaralhosJogador <= filtro.QuantidadeDeBaralhosJogadorMaximo
                        select q;
            }

            return query.ToList();
        }
    }
}