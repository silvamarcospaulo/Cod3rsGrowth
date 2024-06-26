using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoCarta;
using Cod3rsGrowth.Servico.ServicoJogador;
using Cod3rsGrowth.Teste.Singleton;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Teste.Testes
{
    public class BaralhoTest : TesteBase
    {

        private readonly BaralhoServico servicoBaralho;

        private List<CorBaralho> tabelaCorBaralho = SingletonTabelasTeste.InstanciaCorBaralho;
        private List<CopiaDeCartasNoBaralho> tabelaCopiaDeCartasNoBaralho = SingletonTabelasTeste.InstanciaCopiaDeCartasNoBaralho;
        private List<Baralho> tabelaBaralho = SingletonTabelasTeste.InstanciaBaralho;

        public BaralhoTest()
        {
            servicoBaralho = ServiceProvider.GetService<BaralhoServico>() ?? throw new Exception("Erro ao obter servico Baralho");

            tabelaCorBaralho.Clear();
            tabelaCopiaDeCartasNoBaralho.Clear();
            tabelaBaralho.Clear();

            IniciarListaMock();
        }

        private void IniciarListaMock()
        {
            DateTime dataDeHoje = DateTime.Now;

            var listaBaralhosMock = new List<Baralho>()
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
                    CorBaralho = new List<CoresEnum>() {CoresEnum.Verde}
                },
                new Baralho()
                {
                    IdBaralho = 2,
                    IdJogador = 1,
                    NomeBaralho = "Niv-Mizzet Combo",
                    FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander,
                    CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                    {
                        new CopiaDeCartasNoBaralho ()
                        {
                            Carta = new Carta()
                            {
                                IdCarta = 1,
                                NomeCarta = "Ilha",
                                CustoDeManaConvertidoCarta = 0,
                                TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                                RaridadeCarta = RaridadeEnum.Common,
                                PrecoCarta = Convert.ToDecimal(0.5),
                                CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                            },
                            QuantidadeCopiasDaCartaNoBaralho = 49
                        },
                        new CopiaDeCartasNoBaralho ()
                        {
                            Carta = new Carta()
                            {
                                IdCarta = 5,
                                NomeCarta = "Montanha",
                                CustoDeManaConvertidoCarta = 0,
                                TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                                RaridadeCarta = RaridadeEnum.Common,
                                PrecoCarta = Convert.ToDecimal(0.5),
                                CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                            },
                            QuantidadeCopiasDaCartaNoBaralho = 50
                        },
                        new CopiaDeCartasNoBaralho ()
                        {
                            Carta = new Carta()
                            {
                                IdCarta = 8,
                                NomeCarta = "Niv-Mizzet, Parum",
                                CustoDeManaConvertidoCarta = 6,
                                TipoDeCarta = TipoDeCartaEnum.Criatura,
                                RaridadeCarta = RaridadeEnum.Rare,
                                PrecoCarta = Convert.ToDecimal(5),
                                CorCarta = new List<CoresEnum>() { CoresEnum.Azul, CoresEnum.Vermelho }
                            },
                            QuantidadeCopiasDaCartaNoBaralho = 1
                        }
                    },
                    QuantidadeDeCartasNoBaralho = 100,
                    DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                    PrecoDoBaralho = 54.5m,
                    CustoDeManaConvertidoDoBaralho = 0,
                    CorBaralho = new List<CoresEnum>() {CoresEnum.Azul, CoresEnum.Vermelho}
                },
                new Baralho()
                {
                    IdBaralho = 3,
                    IdJogador = 1,
                    NomeBaralho = "Mono Green Stomp",
                    FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                    CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                    {
                        new CopiaDeCartasNoBaralho()
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
                            QuantidadeCopiasDaCartaNoBaralho = 60
                        }
                    },
                    QuantidadeDeCartasNoBaralho = 60,
                    DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                    PrecoDoBaralho = 30,
                    CustoDeManaConvertidoDoBaralho = 0,
                    CorBaralho = new List<CoresEnum>() { CoresEnum.Incolor }
                }
            };

            listaBaralhosMock.ForEach(baralho => servicoBaralho.Criar(
                new Baralho()
                {
                    IdBaralho = baralho.IdBaralho,
                    IdJogador = baralho.IdJogador,
                    NomeBaralho = baralho.NomeBaralho,
                    FormatoDeJogoBaralho = baralho.FormatoDeJogoBaralho,
                    DataDeCriacaoBaralho = baralho.DataDeCriacaoBaralho,
                    QuantidadeDeCartasNoBaralho = baralho.QuantidadeDeCartasNoBaralho,
                    PrecoDoBaralho = baralho.PrecoDoBaralho,
                    CorBaralho = baralho.CorBaralho,
                    CustoDeManaConvertidoDoBaralho = baralho.CustoDeManaConvertidoDoBaralho,
                    CartasDoBaralho = baralho.CartasDoBaralho
                }
            ));
        }

        [Fact]
        public void ao_ObterTodos_verifica_se_a_lista_nao_esta_vazia()
        {
            var baralhos = servicoBaralho.ObterTodos(new BaralhoFiltro());

            Assert.NotEmpty(baralhos);
        }

        [Fact]
        public void ao_ObterTodos_deve_retornar_uma_lista_com_dois_baralhos()
        {
            const int quantidadeDeBaralhosEsperados = 3;

            var quantidadeDeBaralhos = servicoBaralho.ObterTodos(new BaralhoFiltro()).Count();

            Assert.Equal(quantidadeDeBaralhosEsperados, quantidadeDeBaralhos);
        }

        [Fact]
        public void ao_ObterPorId_com_id_dois_retorna_baralho_niv_mizzet_combo()
        {
            var dataDeHoje = DateTime.Now;

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 2,
                IdJogador = 1,
                NomeBaralho = "Niv-Mizzet Combo",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho ()
                    {
                        Carta = new Carta()
                        {
                            IdCarta = 1,
                            NomeCarta = "Ilha",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                            RaridadeCarta = RaridadeEnum.Common,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 49
                    },
                    new CopiaDeCartasNoBaralho ()
                    {
                        Carta = new Carta()
                        {
                            IdCarta = 5,
                            NomeCarta = "Montanha",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                            RaridadeCarta = RaridadeEnum.Common,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 50
                    },
                    new CopiaDeCartasNoBaralho ()
                    {
                        Carta = new Carta()
                        {
                            IdCarta = 8,
                            NomeCarta = "Niv-Mizzet, Parum",
                            CustoDeManaConvertidoCarta = 6,
                            TipoDeCarta = TipoDeCartaEnum.Criatura,
                            RaridadeCarta = RaridadeEnum.Rare,
                            PrecoCarta = Convert.ToDecimal(5),
                            CorCarta = new List<CoresEnum>() { CoresEnum.Azul, CoresEnum.Vermelho }
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 1
                    }
                },
                QuantidadeDeCartasNoBaralho = 100,
                DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                PrecoDoBaralho = 54.5m,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = new List<CoresEnum>() { CoresEnum.Incolor, CoresEnum.Azul, CoresEnum.Vermelho }
            };

            var baralhoMock = servicoBaralho.ObterPorId(baralhoTeste.IdBaralho);

            Assert.Equivalent(baralhoTeste, baralhoMock);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(-2)]
        public void ao_ObterPorId_invalido_ou_inexistente_deve_retornar_Exception(int idBaralhoTeste)
        {
            Assert.Throws<Exception>(() => servicoBaralho.ObterPorId(idBaralhoTeste));
        }

        [Fact]
        public void ao_Criar_com_idJogador_negativo_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "Campo Id do jogador tem quer ser maior do que Um";

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 3,
                IdJogador = -1,
                NomeBaralho = "Mono Green Stomp Pauper",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
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
                        QuantidadeCopiasDaCartaNoBaralho = 60
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = new List<CoresEnum>() { CoresEnum.Incolor }
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Criar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_nome_vazio_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "Campo nome de baralho não pode ser vazio";

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 3,
                IdJogador = 1,
                NomeBaralho = "",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
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
                        QuantidadeCopiasDaCartaNoBaralho = 60
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = new List<CoresEnum>() { CoresEnum.Incolor }
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Criar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_cartas_do_baralho_vazia_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "O baralho deve possuir uma lista de cartas não vazia";

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 3,
                IdJogador = 1,
                NomeBaralho = "Mono Green Stomp Pauper",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>(),
                QuantidadeDeCartasNoBaralho = 0,
                PrecoDoBaralho = 0,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = new List<CoresEnum>() { CoresEnum.Incolor }
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Criar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }
        
        [Theory]
        [InlineData(2)]
        [InlineData(0)]
        public void ao_Criar_commmander_com_mais_de_uma_copia_de_carta_nao_terreno_deve_retornar_Exception(int quantidadeDeCartasTeste)
        {
            const string mensagemDeErroEsperada = "Quantidade de cartas do baralho não compativel com o formato de jogo selecionado";

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 3,
                IdJogador = 1,
                NomeBaralho = "Mono Green Stomp Commander",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho
                    {
                        Carta = new Carta()
                        {
                            IdCarta = 10,
                            NomeCarta = "Sol Ring",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = TipoDeCartaEnum.Artefato,
                            RaridadeCarta = RaridadeEnum.Common,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                        },
                        QuantidadeCopiasDaCartaNoBaralho = quantidadeDeCartasTeste
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = new List<CoresEnum>() { CoresEnum.Incolor }
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Criar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Theory]
        [InlineData(99)]
        [InlineData(101)]
        public void ao_Criar_commmander_com_quantidade_de_cartas_no_baralho_diferente_de_cem_cartas_deve_retornar_Exception(int quantidadeDeCartasTeste)
        {
            const string mensagemDeErroEsperada = "Quantidade de cartas do baralho não compativel com o formato de jogo selecionado";

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 3,
                IdJogador = 1,
                NomeBaralho = "Mono Green Stomp Commander",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
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
                        QuantidadeCopiasDaCartaNoBaralho = quantidadeDeCartasTeste
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = new List<CoresEnum>() { CoresEnum.Incolor }
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Criar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Theory]
        [InlineData(FormatoDeJogoEnum.Pauper)]
        [InlineData(FormatoDeJogoEnum.Standard)]
        public void ao_Criar_com_quantidade_de_cartas_nao_compativel_com_o_tipo_de_jogo_pauper_ou_standard_deve_retornar_Exception(FormatoDeJogoEnum formatoDeJogoTeste)
        {
            const string mensagemDeErroEsperada = "Quantidade de cartas do baralho não compativel com o formato de jogo selecionado";

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 3,
                IdJogador = 1,
                NomeBaralho = "Mono Green Stomp",
                FormatoDeJogoBaralho = formatoDeJogoTeste,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
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
                        QuantidadeCopiasDaCartaNoBaralho = 59
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = new List<CoresEnum>() { CoresEnum.Incolor }
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Criar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_dados_validos_deve_adicionar_um_novo_baralho()
        {
            var dataDeHoje = DateTime.Now;

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 3,
                IdJogador = 1,
                NomeBaralho = "Mono Green Pauper",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
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
                        QuantidadeCopiasDaCartaNoBaralho = 60
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = new List<CoresEnum>() { CoresEnum.Incolor }
            };

            servicoBaralho.Criar(baralhoTeste);

            Assert.Equivalent(baralhoTeste, servicoBaralho.ObterPorId(baralhoTeste.IdBaralho));
        }

        [Fact]
        public void ao_Atualizar_com_dados_validos_deve_adicionar_um_novo_baralho()
        {
            var dataDeHoje = DateTime.Now;

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 3,
                IdJogador = 1,
                NomeBaralho = "Mono Green Stomp",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho()
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
                        QuantidadeCopiasDaCartaNoBaralho = 56
                    },
                    new CopiaDeCartasNoBaralho()
                    {
                        Carta = new Carta()
                        {
                            IdCarta = 6,
                            NomeCarta = "Elfos de Llanowar",
                            CustoDeManaConvertidoCarta = 1,
                            TipoDeCarta = TipoDeCartaEnum.Criatura,
                            RaridadeCarta = RaridadeEnum.Common,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = new List<CoresEnum>() { CoresEnum.Verde }
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 4
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = new List<CoresEnum>() { CoresEnum.Incolor, CoresEnum.Verde }
            };

            servicoBaralho.Atualizar(baralhoTeste);

            Assert.Equivalent(baralhoTeste, servicoBaralho.ObterPorId(baralhoTeste.IdBaralho));
        }

        [Theory]
        [InlineData(FormatoDeJogoEnum.Standard)]
        [InlineData(FormatoDeJogoEnum.Pauper)]
        [InlineData(FormatoDeJogoEnum.Commander)]
        public void ao_Atualizar_com_baralho_invalido_deve_retornar_Exception(FormatoDeJogoEnum formatoDeJogoBaralhoTeste)
        {
            const string mensagemDeErroEsperada = ("Quantidade de cartas do baralho não compativel com o formato de jogo selecionado");

            var dataDeHoje = DateTime.Now;

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 1,
                IdJogador = 1,
                NomeBaralho = "Mono Green Stomp",
                FormatoDeJogoBaralho = formatoDeJogoBaralhoTeste,
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
                CorBaralho = new List<CoresEnum>() {CoresEnum.Verde, CoresEnum.Incolor}
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Atualizar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(5)]
        public void ao_Atualizar_com_id_invalido_ou_inexistente_deve_retornar_Exception(int idBaralhoTeste)
        {
            var mensagemDeErroEsperada = ($"Baralho {idBaralhoTeste} Nao Encontrado");

            var baralhoTeste = new Baralho()
            {
                IdBaralho = idBaralhoTeste,
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Atualizar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Atualizar_nao_deve_alterar_idbaralho_e_idjogador()
        {
            var dataDeHoje = DateTime.Now;

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 3,
                IdJogador = 1,
                NomeBaralho = "Mono Green Stomp",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho()
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
                        QuantidadeCopiasDaCartaNoBaralho = 56
                    },
                    new CopiaDeCartasNoBaralho()
                    {
                        Carta = new Carta()
                        {
                            IdCarta = 6,
                            NomeCarta = "Elfos de Llanowar",
                            CustoDeManaConvertidoCarta = 1,
                            TipoDeCarta = TipoDeCartaEnum.Criatura,
                            RaridadeCarta = RaridadeEnum.Common,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = new List<CoresEnum>() { CoresEnum.Verde }
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 4
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = new List<CoresEnum>() { CoresEnum.Incolor, CoresEnum.Verde }
            };

            var baralhoTesteExistente = servicoBaralho.ObterPorId(baralhoTeste.IdBaralho);

            servicoBaralho.Atualizar(baralhoTeste);

            Assert.Equal(baralhoTesteExistente.IdBaralho, servicoBaralho.ObterPorId(baralhoTeste.IdBaralho).IdBaralho);
            Assert.Equal(baralhoTesteExistente.IdJogador, servicoBaralho.ObterPorId(baralhoTeste.IdBaralho).IdJogador);
        }

        [Fact]
        public void ao_Atualizar_com_cartas_do_baralho_vazia_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "O baralho deve possuir uma lista de cartas não vazia";

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 1,
                IdJogador = 1,
                NomeBaralho = "Mono Green Stomp Pauper",
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Atualizar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Atualizar_com_nome_vazio_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "Campo nome de baralho não pode ser vazio";

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 1,
                IdJogador = 1,
                NomeBaralho = "",
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
                }
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Atualizar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(10)]
        public void ao_Excluir_com_um_id_invalido_ou_inexistente_deve_retornar_Exception(int idBaralhoTeste)
        {
            var mensagemDeErroEsperada = ($"Baralho {idBaralhoTeste} Nao Encontrado");

            var baralhoTeste = new Baralho()
            {
                IdBaralho = idBaralhoTeste,
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Excluir(baralhoTeste.IdBaralho));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_ObterTodos_com_filtro_deve_retornar_lista_filtrada_por_FormatoDeJogo()
        {
            var listaFiltroFormatoDeJogo = servicoBaralho.ObterTodos(new BaralhoFiltro()
            { FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander });

            const FormatoDeJogoEnum formatoDeJogoEsperado = FormatoDeJogoEnum.Commander;

            listaFiltroFormatoDeJogo.ForEach(baralho => Assert.Equal(formatoDeJogoEsperado, baralho.FormatoDeJogoBaralho));
        }
    }
}