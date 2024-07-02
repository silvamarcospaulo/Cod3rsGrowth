﻿using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;

namespace Cod3rsGrowth.Infra.Repository
{
    public class JogadorRepository : IJogadorRepository
    {
        private ConexaoDados conexaoDados;

        public JogadorRepository(ConexaoDados _conexaoDados)
        {
            conexaoDados = _conexaoDados;
        }

        public int Criar(Jogador jogador)
        {
            return conexaoDados.InsertWithInt32Identity(jogador);
        }

        public void Atualizar(Jogador jogador)
        {
            conexaoDados.Update(jogador);
        }

        public void Excluir(int idJogador)
        {
            var jogadorExcluir = ObterPorId(idJogador);
            conexaoDados.Delete(jogadorExcluir);
        }

        public Jogador ObterPorId(int idJogador)
        {
            return conexaoDados.GetTable<Jogador>().FirstOrDefault(jogador => jogador.Id == idJogador) ??
                throw new Exception($"Jogador {idJogador} Nao Encontrada");
        }

        public List<Jogador> ObterTodos(JogadorFiltro? filtro)
        {
            IQueryable<Jogador> query = from q in conexaoDados.TabelaJogador
                                            select q;

            if ((filtro?.UsuarioJogador != null) && (filtro?.SenhaJogador != null))
            {
                query = from q in query
                        where q.UsuarioJogador == filtro.UsuarioJogador
                        where q.SenhaJogador == filtro.SenhaJogador
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