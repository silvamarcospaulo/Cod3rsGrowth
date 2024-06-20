﻿using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Teste.Singleton;
using System;

namespace Cod3rsGrowth.Teste.Repository
{
    public class BaralhoRepositoryMock : IBaralhoRepository
    {
        private List<Baralho> tabelasBaralhos = SingletonTabelasTeste.InstanciaBaralhos;

        public void Criar(Baralho baralho)
        {
            tabelasBaralhos.Add(baralho);
        }

        public void Atualizar(Baralho baralho)
        {
            var baralhoBanco = ObterPorId(baralho.IdJogador);
            baralhoBanco = baralho;
        }

        public void Excluir(int idBaralho)
        {
            var baralhoExcluir = ObterPorId(idBaralho);
            tabelasBaralhos.Remove(baralhoExcluir);
        }

        public Baralho ObterPorId(int idBaralho)
        {
            return tabelasBaralhos.FirstOrDefault(carta => carta.IdBaralho == idBaralho) ?? throw new Exception($"Baralho {idBaralho} Nao Encontrado");
        }

        public List<Baralho> ObterTodos(BaralhoFiltro? filtro)
        {
            return tabelasBaralhos;
        }
    }
}