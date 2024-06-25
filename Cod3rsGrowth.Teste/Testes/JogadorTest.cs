using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Teste.Singleton;
using LinqToDB.Common;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Teste.Testes
{
    public class JogadorTest : TesteBase
    {
        private readonly JogadorServico servicoJogador;
        private List<Carta> tabelaCarta = SingletonTabelasTeste.InstanciaCarta;
        private List<CorCarta> tabelaCorCarta = SingletonTabelasTeste.InstanciaCorCarta;
        private List<CorBaralho> tabelaCorBaralho = SingletonTabelasTeste.InstanciaCorBaralho;
        private List<CopiaDeCartasNoBaralho> tabelaCopiaDeCartasNoBaralho = SingletonTabelasTeste.InstanciaCopiaDeCartasNoBaralho;
        private List<Baralho> tabelaBaralho = SingletonTabelasTeste.InstanciaBaralho;
        private List<Jogador> tabelaJogador = SingletonTabelasTeste.InstanciaJogador;

        public JogadorTest()
        {
            servicoJogador = ServiceProvider.GetService<JogadorServico>() ?? throw new Exception("Erro ao obter servico Jogador");

            tabelaCorCarta.Clear();
            tabelaCarta.Clear();
            tabelaCorBaralho.Clear();
            tabelaCopiaDeCartasNoBaralho.Clear();
            tabelaBaralho.Clear();
            tabelaJogador.Clear();

            IniciarListaMock();
        }

        public void IniciarListaMock()
        {
            var listaJogadoresMock = new List<Jogador>()
            {
                new Jogador()
                {
                    NomeJogador = "Marcos",
                    DataNascimentoJogador = new DateTime(day: 8, month: 3, year: 1999),
                },
                new Jogador()
                {
                    NomeJogador = "Paulo",
                    DataNascimentoJogador = new DateTime(day: 9, month: 3, year: 1999),
                },
                new Jogador()
                {
                    NomeJogador = "Silva",
                    DataNascimentoJogador = new DateTime(day: 10, month: 3, year: 1999),
                }
            };

            listaJogadoresMock.ForEach(jogador => servicoJogador.Criar(jogador));
        }

        [Fact]
        public void ao_ObterTodos_verifica_se_a_lista_de_nao_esta_vazia()
        {
            Assert.IsType<List<Jogador>>(servicoJogador.ObterTodos(new JogadorFiltro()));
        }

        [Fact]
        public void ao_ObterTodos_deve_retornar_uma_lista_com_tres_jogadores()
        {
            const int quantidadeDeJogadoresEsperados = 3;

            var quantidadeDeJogadores = servicoJogador.ObterTodos(new JogadorFiltro()).Count();

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
                ContaAtivaJogador = false,
                BaralhosJogador = new List<Baralho>()
            };

            var jogadorMock = servicoJogador.ObterPorId(jogadorTeste.IdJogador);

            Assert.Equivalent(jogadorTeste, jogadorMock);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        public void ao_ObterPorId_invalido_ou_inexistente_deve_retornar_Exception(int idJogadorTeste)
        {
            Assert.Throws<Exception>(() => servicoJogador.ObterPorId(idJogadorTeste));
        }

        [Fact]
        public void ao_Criar_com_nome_vazio_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "Nome do Jogador nao preenchido";

            var jogadorTeste = new Jogador()
            {
                IdJogador = 4,
                NomeJogador = "",
                DataNascimentoJogador = new DateTime(day: 29, month: 11, year: 2005),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = new List<Baralho>()
            };

            var resultado = Assert.Throws<Exception>(() => servicoJogador.Criar(jogadorTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_data_de_nascimento_vazia_deve_retornar_Excepion()
        {
            const string mensagemDeErroEsperada = "Data de nascimente nao preenchida";

            var jogadorTeste = new Jogador()
            {
                IdJogador = 4,
                NomeJogador = "Detofol",
                DataNascimentoJogador = new DateTime(),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = new List<Baralho>()
            };

            var resultado = Assert.Throws<Exception>(() => servicoJogador.Criar(jogadorTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_idade_menor_que_treze_anos_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "O jogador deve possuir mais de 13 anos para criar conta";

            var jogadorTeste = new Jogador()
            {
                NomeJogador = "Detofol",
                DataNascimentoJogador = new DateTime(day: 1, month: 06, year: 2023),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = new List<Baralho>()
            };

            var resultado = Assert.Throws<Exception>(() => servicoJogador.Criar(jogadorTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_dados_validos_deve_adicionar_um_novo_jogador()
        {
            var jogadorTeste = new Jogador()
            {
                IdJogador = 4,
                NomeJogador = "Detofol",
                DataNascimentoJogador = new DateTime(day: 29, month: 11, year: 2005),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = new List<Baralho>()
            };

            servicoJogador.Criar(jogadorTeste);

            Assert.Equal(jogadorTeste, servicoJogador.ObterPorId(jogadorTeste.IdJogador));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void ao_Atualizar_com_dados_validos_deve_adicionar_um_novo_jogador(int idJogadorTeste)
        {


            var jogadorTeste = servicoJogador.ObterPorId(idJogadorTeste);

            servicoJogador.Atualizar(jogadorTeste);

            Assert.Equivalent(jogadorTeste, servicoJogador.ObterPorId(idJogadorTeste));
        }

        [Theory]
        [InlineData(FormatoDeJogoEnum.Standard)]
        [InlineData(FormatoDeJogoEnum.Pauper)]
        [InlineData(FormatoDeJogoEnum.Commander)]
        public void ao_Atualizar_com_baralho_invalido_deve_retornar_Exception(FormatoDeJogoEnum formatoDeJogoBaralhoJogadorTeste)
        {
            const string mensagemDeErroEsperada = ("Quantidade de cartas do baralho nao compativel com o formato de jogo selecionado");

            var dataDeHoje = DateTime.Now;

            var jogadorTeste = new Jogador()
            {
                IdJogador = 1,
                NomeJogador = "Marcos",
                DataNascimentoJogador = new DateTime(day: 8, month: 3, year: 1999),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = new List<Baralho>()
                {
                    new Baralho()
                    {
                        IdBaralho = 1,
                        IdJogador = 1,
                        NomeBaralho = "Mono Green Stomp",
                        FormatoDeJogoBaralho = formatoDeJogoBaralhoJogadorTeste,
                        CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                        {
                            new CopiaDeCartasNoBaralho
                            {
                                Carta = new Carta()
                                {
                                    IdCarta = 7,
                                    NomeCarta = "Ghalta, Fome Primordial",
                                    CustoDeManaConvertidoCarta = 12,
                                    TipoDeCarta = TipoDeCartaEnum.Criatura,
                                    RaridadeCarta = RaridadeEnum.Rare,
                                    PrecoCarta = Convert.ToDecimal(5),
                                    CorCarta = new List<CoresEnum>() { CoresEnum.Verde }
                                },
                                QuantidadeCopiasDaCartaNoBaralho = 1
                            },
                            new CopiaDeCartasNoBaralho
                            {
                                Carta = new Carta()
                                {
                                    IdCarta = 3,
                                    NomeCarta = "Floresta",
                                    CustoDeManaConvertidoCarta = 0,
                                    TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                                    RaridadeCarta = RaridadeEnum.Common,
                                    PrecoCarta = Convert.ToDecimal(0.5),
                                    CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                                },
                                QuantidadeCopiasDaCartaNoBaralho = 20
                            }
                        },
                        QuantidadeDeCartasNoBaralho = 21,
                        DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                        PrecoDoBaralho = 54.5m,
                        CustoDeManaConvertidoDoBaralho = 0,
                        CorBaralho = new List<CoresEnum>() {CoresEnum.Verde}
                    }
                }
            };

            var resultado = Assert.Throws<Exception>(() => servicoJogador.Atualizar(jogadorTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(4)]
        public void ao_Atualizar_com_id_invalido_ou_inexistente_deve_retornar_Exception(int idJogadorTeste)
        {
            var mensagemDeErroEsperada = ($"Jogador {idJogadorTeste} Nao Encontrado");

            var jogadorTeste = new Jogador()
            {
                IdJogador = idJogadorTeste
            };

            var resultado = Assert.Throws<Exception>(() => servicoJogador.Atualizar(jogadorTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Atualizar_nao_deve_ser_alterar_nome_e_data_de_nascimento()
        {
            var dataDeHoje = DateTime.Now;

            var jogadorTeste = new Jogador()
            {
                IdJogador = 1,
                NomeJogador = "SIlv Silva",
                DataNascimentoJogador = new DateTime(day: 10, month: 3, year: 1999),
                PrecoDasCartasJogador = 0,
                QuantidadeDeBaralhosJogador = 0,
                ContaAtivaJogador = true,
                BaralhosJogador = new List<Baralho>()
                {
                    new Baralho()
                    {
                        IdBaralho = 1,
                        IdJogador = 1,
                        NomeBaralho = "Mono Green Stomp",
                        FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander,
                        CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                        {
                            new CopiaDeCartasNoBaralho
                            {
                                Carta = new Carta()
                                {
                                    IdCarta = 7,
                                    NomeCarta = "Ghalta, Fome Primordial",
                                    CustoDeManaConvertidoCarta = 12,
                                    TipoDeCarta = TipoDeCartaEnum.Criatura,
                                    RaridadeCarta = RaridadeEnum.Rare,
                                    PrecoCarta = Convert.ToDecimal(5),
                                    CorCarta = new List<CoresEnum>() { CoresEnum.Verde }
                                },
                                QuantidadeCopiasDaCartaNoBaralho = 1
                            },
                            new CopiaDeCartasNoBaralho
                            {
                                Carta = new Carta()
                                {
                                    IdCarta = 3,
                                    NomeCarta = "Floresta",
                                    CustoDeManaConvertidoCarta = 0,
                                    TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                                    RaridadeCarta = RaridadeEnum.Common,
                                    PrecoCarta = Convert.ToDecimal(0.5),
                                    CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                                },
                                QuantidadeCopiasDaCartaNoBaralho = 99
                            }
                        },
                        QuantidadeDeCartasNoBaralho = 100,
                        DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                        PrecoDoBaralho = 54.5m,
                        CustoDeManaConvertidoDoBaralho = 0,
                        CorBaralho = new List<CoresEnum>() { CoresEnum.Verde }
                    }
                }
            };

            var jogadorTesteExistente = servicoJogador.ObterPorId(jogadorTeste.IdJogador);

            servicoJogador.Atualizar(jogadorTeste);

            Assert.Equal(jogadorTesteExistente.NomeJogador, servicoJogador.ObterPorId(jogadorTeste.IdJogador).NomeJogador);
            Assert.Equal(jogadorTesteExistente.DataNascimentoJogador, servicoJogador.ObterPorId(jogadorTeste.IdJogador).DataNascimentoJogador);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void ao_Excluir_com_id_valido_deve_remover_o_jogador_correspondente(int idJogadorTeste)
        {
            var mensagemDeErroEsperada = ($"Jogador {idJogadorTeste} Nao Encontrado");

            servicoJogador.Excluir(idJogadorTeste);

            var resultado = Assert.Throws<Exception>(() => servicoJogador.ObterPorId(idJogadorTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(4)]
        public void ao_Excluir_com_um_id_invalido_ou_inexistente_deve_retornar_Exception(int idJogadorTeste)
        {
            var mensagemDeErroEsperada = ($"Jogador {idJogadorTeste} Nao Encontrado");

            var jogadorTeste = new Jogador()
            {
                IdJogador = idJogadorTeste,
            };

            var resultado = Assert.Throws<Exception>(() => servicoJogador.Excluir(jogadorTeste.IdJogador));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }
    }
}