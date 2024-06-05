using System;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository.RepositoryJogador
{
    public interface IJogadorRepository
    {
        void Inserir(Jogador jogador);
        void Excluir(int idJogador);
        Jogador ObterPorId(string idJogador);
        List<Jogador> ObterTodos();
    }
}