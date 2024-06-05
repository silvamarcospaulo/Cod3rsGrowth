using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Cod3rsGrowth.Teste.Singleton;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Teste.Repository
{
    public class JogadorRepositoryMock : IJogadorRepository
    {
        public List<Jogador> tabelasJogadores = SingletonTabelas.InstanciaJogadores;

        public void Inserir(Jogador jogador)
        {
            tabelasJogadores.Add(jogador);
        }

        public void Excluir(int idJogador)
        {
        }

        public Jogador ObterPorId(string idJogador)
        {
            return idJogador.Length != 11 ? throw new Exception("Valor Invalido")
                : tabelasJogadores.FirstOrDefault(carta => carta.IdJogador == idJogador) ?? throw new Exception("Jogador Nao Encontrado");
        }

        public List<Jogador> ObterTodos()
        {
            return tabelasJogadores;
        }
    }
}