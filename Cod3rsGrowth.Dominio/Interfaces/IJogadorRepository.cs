using System;
using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Dominio.Interfaces
{
    public interface IJogadorRepository
    {
        void Criar(Jogador jogador);
        void Atualizar(Jogador jogador);
        void Excluir(Jogador jogador);
        Jogador ObterPorId(int idJogador);
        List<Jogador> ObterTodos(JogadorFiltro? filtro);
    }
}