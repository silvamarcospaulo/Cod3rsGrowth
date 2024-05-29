using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Cod3rsGrowth.Teste.TesteJogador
{
    public class JogadorTesteObterTodos : TesteBase
    {
        private readonly IJogadorRepository ObterServico;
        public JogadorTesteObterTodos()
        {
            ObterServico = ServiceProvider.GetService<IJogadorRepository>() ?? throw new Exception("Erro ao obter servico");
        }

        [Fact]
        public void JogadorRepositoryObterTodosDeveRetornarListaNaoNula()
        {
            // arrange
            // act
            var jogadores = ObterServico.ObterTodos();

            // assert
            Assert.NotNull(jogadores);
        }

        [Fact]
        public void JogadorRepositoryObterTodosDeveRetornarListaNaoVazia()
        {
            // arrange
            // act
            var jogadores = ObterServico.ObterTodos();

            // assert
            Assert.NotEmpty(jogadores);
        }

        [Fact]
        public void JogadorRepositoryObterTodosDeveRetornarTodasAsCartasDoRepositorioMock()
        {
            // arrange
            List<Jogador> listaDeJogadores = new()
            {
                new Jogador()
                {
                    IdJogador = 1,
                    NomeJogador = "Marcos",
                    DataNascimentoJodador = Convert.ToDateTime("08/03/1999"),
                    CustoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                },
                new Jogador()
                {
                    IdJogador = 2,
                    NomeJogador = "Paulo",
                    DataNascimentoJodador = Convert.ToDateTime("09/03/1999"),
                    CustoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                },
                new Jogador()
                {
                    IdJogador = 3,
                    NomeJogador = "Silva",
                    DataNascimentoJodador = Convert.ToDateTime("10/03/1999"),
                    CustoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                }
            };
            // act
            var jogadores = ObterServico.ObterTodos();

            // assert
            Assert.Equivalent(listaDeJogadores, jogadores);
        }
    }
}