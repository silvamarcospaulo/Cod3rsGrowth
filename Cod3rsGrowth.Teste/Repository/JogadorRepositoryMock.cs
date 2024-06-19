using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
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
        public void Excluir(Jogador jogador)
        {
            tabelasJogadores.Remove(jogador);
        }
        public void Atualizar(Jogador jogador)
        {
            var jogadorBanco = ObterPorId(jogador.IdJogador);
            jogadorBanco = jogador;
        }
        public Jogador ObterPorId(int idJogador)
        {
            return tabelasJogadores.FirstOrDefault(jogador => jogador.IdJogador == idJogador) ?? throw new Exception($"Jogador {idJogador} Nao Encontrado");
        }

        public void Criar(Jogador jogador)
        {
            Inserir(jogador);
        }
        public List<Jogador> ObterTodos(JogadorFiltro? filtro)
        {
            return tabelasJogadores;
        }
    }
}