using System;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository.RepositoryJogador
{
    public interface IJogadorRepository
    {
        public void Excluir(int idJogador);

        public Jogador ObterPorId(int idJogador);

        public List<Jogador> ObterTodos();
    }
}