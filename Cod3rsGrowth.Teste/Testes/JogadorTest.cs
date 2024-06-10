using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Cod3rsGrowth.Servicos.ServicoJogador;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Cod3rsGrowth.Teste.Testes
{
    public class JogadorTest : TesteBase
    {
        private readonly ServicoJogador ObterServico;
        public JogadorTest()
        {
            ObterServico = ServiceProvider.GetService<ServicoJogador>() ?? throw new Exception("Erro ao obter servico");
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
                    DataNascimentoJogador = Convert.ToDateTime("08/03/1999"),
                    PrecoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                },
                new Jogador()
                {
                    IdJogador = 2,
                    NomeJogador = "Paulo",
                    DataNascimentoJogador = Convert.ToDateTime("09/03/1999"),
                    PrecoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                },
                new Jogador()
                {
                    IdJogador = 3,
                    NomeJogador = "Silva",
                    DataNascimentoJogador = Convert.ToDateTime("10/03/1999"),
                    PrecoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                }
            };

            ObterServico.ObterTodos().Clear();

            listaJogadoresMock.ForEach(jogador => ObterServico.CriarJogador(new Jogador()
            {
                NomeJogador = jogador.NomeJogador,
                DataNascimentoJogador = jogador.DataNascimentoJogador,
                BaralhosJogador = jogador.BaralhosJogador,
                ContaAtivaJogador = jogador.ContaAtivaJogador
            }));
        }

        [Fact]
        public void ao_ObterTodos_verifica_se_a_lista_de_nao_esta_vazia()
        {
            var jogadores = ObterServico.ObterTodos();

            Assert.NotEmpty(jogadores);
        }

        [Fact]
        public void ao_ObterTodos_deve_retornar_uma_lista_com_tres_jogadores()
        {
            const int quantidadeDeJogadoresEsperados = 3;

            var quantidadeDeJogadores = ObterServico.ObterTodos().Count();

            Assert.Equal(quantidadeDeJogadoresEsperados, quantidadeDeJogadores);
        }

        [Fact]
        public void ao_ObterPorId_um_retornar_jogador_Marcos()
        {
            var jogadorTeste = new Jogador()
            {
                IdJogador = 1,
                NomeJogador = "Marcos",
                DataNascimentoJogador = Convert.ToDateTime("08/03/1999"),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = null
            };

            var jogadorMock = ObterServico.ObterPorId(jogadorTeste.IdJogador);

            Assert.Equivalent(jogadorTeste, jogadorMock);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        public void ao_ObterPorId_invalido_ou_inexistente_deve_retornar_Exception(int idJogadorTeste)
        {
            Assert.Throws<Exception>(() => ObterServico.ObterPorId(idJogadorTeste));
        }

        [Fact]
        public void ao_CriarJogador_com_dados_nulos_deve_retornar_Exception()
        {
            var jogadorTeste = new Jogador();

            Assert.Throws<Exception>(() => ObterServico.CriarJogador(jogadorTeste));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ao_CriarJogador_com_nome_nulo_ou_vazio_deve_retornar_Exception(string nomeJogadorTeste)
        {
            var jogadorTeste = new Jogador()
            {
                IdJogador = 4,
                NomeJogador = nomeJogadorTeste,
                DataNascimentoJogador = Convert.ToDateTime("29/11/2005"),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = null
            };

            Assert.Throws<Exception>(() => ObterServico.CriarJogador(jogadorTeste));
        }

        [Fact]
        public void ao_CriarJogador_com_dados_validos_deve_adicionar_ao_banco_de_dados()
        {
            var jogadorTeste = new Jogador()
            {
                IdJogador = 4,
                NomeJogador = "Detofol",
                DataNascimentoJogador = Convert.ToDateTime("29/11/2005"),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = null
            };

            ObterServico.CriarJogador(jogadorTeste);

            Assert.Equivalent(jogadorTeste, ObterServico.ObterPorId(ObterServico.ObterTodos().Count()));
        }
    }
}