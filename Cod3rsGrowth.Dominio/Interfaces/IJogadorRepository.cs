using System;
using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Dominio.Interfaces
{
    public interface IJogadorRepository
    {
        int Criar(Jogador jogador);
        Jogador Atualizar(Jogador jogador);
        void Excluir(int idJogador);
        Jogador ObterPorId(int idJogador);
        List<Jogador> ObterTodos(JogadorFiltro? filtro);
    }
}