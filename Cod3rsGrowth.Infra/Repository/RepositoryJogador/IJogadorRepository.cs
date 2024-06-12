using System;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository.RepositoryJogador
{
    public interface IJogadorRepository
    {
        void Inserir(Jogador jogador);
        void Excluir(Jogador jogador);
        Jogador ObterPorId(int idJogador);
        List<Jogador> ObterTodos();
        void Criar(Jogador jogador);
        void Atualizar(Jogador jogador);
    }
}