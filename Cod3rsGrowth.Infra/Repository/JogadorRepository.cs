﻿using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using LinqToDB;
using System;

namespace Cod3rsGrowth.Infra.Repository
{
    public class JogadorRepository : IJogadorRepository
    {

        public void Criar(Jogador jogador)
        {
            using (var conexaoDados = new ConexaoDados())
            {
                conexaoDados.Insert(jogador);
            }
        }

        public void Atualizar(Jogador jogador)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Jogador jogador)
        {
            throw new NotImplementedException();
        }

        public Jogador ObterPorId(int idJogador)
        {
            throw new NotImplementedException();
        }

        public List<Jogador> ObterTodos(JogadorFiltro? filtro)
        {
            using (var conexaoDados = new ConexaoDados())
            {
                IQueryable<Jogador> query = from q in conexaoDados.TabelaJogadores
                                             select q;

                if (filtro.NomeJogador != null)
                {
                    query = from q in query
                            where q.NomeJogador.Contains(filtro.NomeJogador)
                            select q;
                }

                if (filtro.ContaAtivaJogador != null)
                {
                    query = from q in query
                            where q.ContaAtivaJogador == filtro.ContaAtivaJogador
                            select q;
                }

                if (filtro.DataNascimentoJogadorMinimo != null)
                {
                    query = from q in query
                            where q.DataNascimentoJogador >= filtro.DataNascimentoJogadorMinimo
                            select q;
                }

                if (filtro.DataNascimentoJogadorMaximo != null)
                {
                    query = from q in query
                            where q.DataNascimentoJogador <= filtro.DataNascimentoJogadorMaximo
                            select q;
                }

                if (filtro.PrecoDasCartasJogadorMinimo != null)
                {
                    query = from q in query
                            where q.PrecoDasCartasJogador >= filtro.PrecoDasCartasJogadorMinimo
                            select q;
                }

                if (filtro.DataNascimentoJogadorMaximo != null)
                {
                    query = from q in query
                            where q.PrecoDasCartasJogador <= filtro.PrecoDasCartasJogadorMaximo
                            select q;
                }

                if (filtro.QuantidadeDeBaralhosJogadorMinimo != null)
                {
                    query = from q in query
                            where q.QuantidadeDeBaralhosJogador >= filtro.QuantidadeDeBaralhosJogadorMinimo
                            select q;
                }

                if (filtro.QuantidadeDeBaralhosJogadorMaximo != null)
                {
                    query = from q in query
                            where q.QuantidadeDeBaralhosJogador <= filtro.QuantidadeDeBaralhosJogadorMaximo
                            select q;
                }

                return query.ToList();
            }
        }
    }
}