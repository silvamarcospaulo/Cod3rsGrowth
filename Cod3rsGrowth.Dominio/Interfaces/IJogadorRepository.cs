using System;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Dominio.Interfaces
{
    public interface IJogadorRepository
    {
        void Excluir(Jogador jogador);
        Jogador ObterPorId(int idJogador);
        List<Jogador> ObterTodos();
        void Criar(Jogador jogador);
        void Atualizar(Jogador jogador);
    }
}