using System;
using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Infra.Repository.RepositoryJogador
{
    public class JogadorRepository : IJogadorRepository
    {
        public void Inserir(Jogador jogador)
        {
        }
        public void Excluir(int idJogador)
        {
            throw new NotImplementedException();
        }

        public Jogador ObterPorId(string idJogador)
        {
            throw new NotImplementedException();
        }

        public List<Jogador> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
