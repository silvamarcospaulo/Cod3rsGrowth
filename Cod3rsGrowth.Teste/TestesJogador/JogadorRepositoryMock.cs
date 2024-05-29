using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Cod3rsGrowth.Teste.Singleton;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Teste.TestesJogador
{
    public class JogadorRepositoryMock : IJogadorRepository
    {
        public List<Jogador> listaDeJogadores = SingletonTabelas.InstanciaJogadores;
        public void Excluir(int idJogador)
        {
        }

        public Jogador ObterPorId(int idJogador)
        {
            return new Jogador();
        }

        public List<Jogador> ObterTodos()
        {
            return listaDeJogadores;
        }
    }
}