using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Cod3rsGrowth.Teste.Testes
{
    public class JogadorTest : TesteBase
    {
        private readonly IJogadorRepository ObterServico;
        public JogadorTest()
        {
            ObterServico = ServiceProvider.GetService<IJogadorRepository>() ?? throw new Exception("Erro ao obter servico");
            IniciarListaMock();
        }

        public void IniciarListaMock()
        {
            List<Jogador> listaJogadoresMock = new List<Jogador>()
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

            listaJogadoresMock.ForEach(jogador => ObterServico.Inserir(jogador));
        }

        [Fact]
        public void verifica_se_a_lista_de_esta_vazia()
        {
            var jogadores = ObterServico.ObterTodos();

            Assert.NotEmpty(jogadores);
        }

        [Fact]
        public void verifica_se_o_metodo_retorna_todas_as_cartas()
        {
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

            var jogadores = ObterServico.ObterTodos();

            Assert.Equivalent(listaDeJogadores, jogadores);
        }
    }
}