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
                    DataNascimentoJogador = new DateTime(day: 8, month: 3, year: 1999),
                    PrecoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                },
                new Jogador()
                {
                    IdJogador = 2,
                    NomeJogador = "Paulo",
                    DataNascimentoJogador = new DateTime(day: 9, month: 3, year: 1999),
                    PrecoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                },
                new Jogador()
                {
                    IdJogador = 3,
                    NomeJogador = "Silva",
                    DataNascimentoJogador = new DateTime(day: 10, month: 3, year: 1999),
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
                DataNascimentoJogador = new DateTime(day: 8, month: 3, year: 1999),
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
        public void ao_CriarJogador_com_nome_vazio_deve_retornar_Exception()
        {
            const string mensagemEsperada = "Nome do Jogador nao preenchido";

            var jogadorTeste = new Jogador()
            {
                IdJogador = 4,
                NomeJogador = "",
                DataNascimentoJogador = new DateTime(day: 29, month: 11, year: 2005),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = null
            };

            var resultado = ObterServico.CriarJogador(jogadorTeste);

            var mensagemDeErro = resultado.Errors.FirstOrDefault(e => e.PropertyName == "NomeJogador")?.ErrorMessage;

            Assert.Equal(mensagemEsperada, mensagemDeErro);
        }
        
        [Fact]
        public void ao_CriarJogador_com_data_de_nascimento_vazia_deve_retornar_Excepion()
        {
            const string mensagemEsperada = "Data de nascimente nao preenchida";

            var jogadorTeste = new Jogador()
            {
                IdJogador = 4,
                NomeJogador = "Detofol",
                DataNascimentoJogador = new DateTime(),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = null
            };

            var resultado = ObterServico.CriarJogador(jogadorTeste);

            var mensagemDeErro = resultado.Errors.FirstOrDefault(e => e.PropertyName == "DataNascimentoJogador")?.ErrorMessage;

            Assert.Equal(mensagemEsperada, mensagemDeErro);
        }

        [Fact]
        public void ao_CriarJogador_com_idade_menor_que_treze_anos_deve_retornar_Excepion()
        {
            const string mensagemEsperada = "O jogador deve possuir mais de 13 anos para criar conta";

            var jogadorTeste = new Jogador()
            {
                IdJogador = 4,
                NomeJogador = "Detofol",
                DataNascimentoJogador = new DateTime(day: 12, month: 06, year: 2011),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = null
            };

            var resultado = ObterServico.CriarJogador(jogadorTeste);

            var mensagemDeErro = resultado.Errors.FirstOrDefault(e => e.PropertyName == "DataNascimentoJogador")?.ErrorMessage;

            Assert.Equal(mensagemEsperada, mensagemDeErro);
        }

        [Fact]
        public void ao_CriarJogador_com_dados_validos_deve_adicionar_ao_banco_de_dados()
        {
            var jogadorTeste = new Jogador()
            {
                IdJogador = 4,
                NomeJogador = "Detofol",
                DataNascimentoJogador = new DateTime(day: 29, month: 11, year: 2005),
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