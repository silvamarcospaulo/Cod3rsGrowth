using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Interfaces;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Teste.Singleton;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Teste.Repository
{
    public class JogadorRepositoryMock : IJogadorRepository
    {
        public List<Jogador> tabelasJogadores = SingletonTabelasTeste.InstanciaJogadores;

        private int GerarId()
        {
            const int ValorInicial = 1;
            const int Incremento = 1;

            var JogadoresBanco = ObterTodos(null);
            var ultimoId = JogadoresBanco.Any() ? JogadoresBanco.Max(jogador => jogador.IdJogador) : ValorInicial - Incremento;

            return ultimoId + Incremento;
        }

        public void Criar(Jogador jogador)
        {
            jogador.IdJogador = GerarId();
            tabelasJogadores.Add(jogador);
        }

        public void Atualizar(Jogador jogador)
        {
            var jogadorBanco = ObterPorId(jogador.IdJogador);
            jogadorBanco = jogador;
        }

        public void Excluir(int idJogador)
        {
            var jogadorExcluir = ObterPorId(idJogador);
            tabelasJogadores.Remove(jogadorExcluir);
        }

        public Jogador ObterPorId(int idJogador)
        {
            return tabelasJogadores.FirstOrDefault(jogador => jogador.IdJogador == idJogador) ?? throw new Exception($"Jogador {idJogador} Nao Encontrado");
        }

        public List<Jogador> ObterTodos(JogadorFiltro? filtro)
        {
            return tabelasJogadores;
        }
    }
}