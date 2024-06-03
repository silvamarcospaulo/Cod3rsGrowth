using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Cod3rsGrowth.Servicos.ServicoJogador;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Cod3rsGrowth.Teste.Testes
{
    public class JogadorTest : TesteBase
    {
        private readonly IServicoJogador ObterServico;
        public JogadorTest()
        {
            ObterServico = ServiceProvider.GetService<IServicoJogador>() ?? throw new Exception("Erro ao obter servico");
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
        public void verifica_se_a_lista_de_nao_esta_vazia()
        {
            var jogadores = ObterServico.ObterTodos();

            Assert.NotEmpty(jogadores);
        }

        [Fact]
        public void ao_ObterTodos_deve_retornar_uma_lista_com_tres_jogadores()
        {
            var quantidadeDeJogadores = ObterServico.ObterTodos().Count();

            Assert.Equal(3, quantidadeDeJogadores);
        }

        [Fact]
        public void ao_ObterTodos_compara_se_os_primeiros_elementos_sao_iguais()
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

            Assert.Equal(listaDeJogadores.First().IdJogador, jogadores.First().IdJogador);
            Assert.Equal(listaDeJogadores.First().NomeJogador, jogadores.First().NomeJogador);
            Assert.Equal(listaDeJogadores.First().DataNascimentoJodador, jogadores.First().DataNascimentoJodador);
            Assert.Equal(listaDeJogadores.First().CustoDasCartasJogador, jogadores.First().CustoDasCartasJogador);
            Assert.Equal(listaDeJogadores.First().QuantidadeDeBaralhosJogador, jogadores.First().QuantidadeDeBaralhosJogador);
            Assert.Equal(listaDeJogadores.First().ContaAtivaJogador, jogadores.First().ContaAtivaJogador);
            Assert.Equal(listaDeJogadores.First().BaralhosJogador, jogadores.First().BaralhosJogador);
        }
    }
}