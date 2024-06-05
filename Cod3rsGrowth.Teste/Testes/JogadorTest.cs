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
                    IdJogador = "12345678911",
                    NomeJogador = "Marcos",
                    DataNascimentoJodador = Convert.ToDateTime("08/03/1999"),
                    CustoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                },
                new Jogador()
                {
                    IdJogador = "12345678912",
                    NomeJogador = "Paulo",
                    DataNascimentoJodador = Convert.ToDateTime("09/03/1999"),
                    CustoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                },
                new Jogador()
                {
                    IdJogador = "12345678913",
                    NomeJogador = "Silva",
                    DataNascimentoJodador = Convert.ToDateTime("10/03/1999"),
                    CustoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = null
                }
            };

            ObterServico.ObterTodos().Clear();

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
        public void ao_ObterPorId_deve_retornar_Exception_quando_informado_id_invalido()
        {
            var idJogadorTeste = "123456789121";

            var baralhoMock = Assert.Throws<Exception>(() => { ObterServico.ObterPorId(idJogadorTeste); });

            var mensagemDeErroEsperada = "Valor Invalido";

            Assert.Equal(mensagemDeErroEsperada, baralhoMock.Message);
        }

        [Fact]
        public void ao_ObterPorId_deve_retornar_Exception_quando_informado_id_nao_existente()
        {
            var idJogadorTeste = "12345678914";

            var baralhoMock = Assert.Throws<Exception>(() => { ObterServico.ObterPorId(idJogadorTeste); });

            var mensagemDeErroEsperada = "Jogador Nao Encontrado";

            Assert.Equal(mensagemDeErroEsperada, baralhoMock.Message);
        }
    }
}