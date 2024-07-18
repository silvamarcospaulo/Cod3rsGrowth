using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Teste.Singleton;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Teste.Testes
{
    public class BaralhoTest : TesteBase
    {

        private readonly BaralhoServico servicoBaralho;

        private List<Baralho> tabelaBaralho = SingletonTabelasTeste.InstanciaBaralho;
        private List<CopiaDeCartasNoBaralho> tabelaCartasDoBaralho = SingletonTabelasTeste.InstanciaCopiaDeCartasNoBaralho;

        public BaralhoTest()
        {
            servicoBaralho = ServiceProvider.GetService<BaralhoServico>() ?? throw new Exception("Erro ao obter servico Baralho");

            tabelaBaralho.Clear();
            tabelaCartasDoBaralho.Clear();

            IniciarListaMock();
        }

        private void IniciarListaMock()
        {
            DateTime dataDeHoje = DateTime.Now;

            var listaBaralhosMock = new List<Baralho>()
            {
                new Baralho()
                {
                    IdJogador = 5,
                    NomeBaralho = "Mono Green Stomp",
                    FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander,
                    CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                    {
                        new CopiaDeCartasNoBaralho
                        {
                            IdCarta = 7,
                            Carta = new Carta()
                            {
                                Id = 7,
                                NomeCarta = "Ghalta, Fome Primordial",
                                CustoDeManaConvertidoCarta = 12,
                                TipoDeCarta = "Creature",
                                RaridadeCarta = RaridadeEnum.Raro,
                                PrecoCarta = 5m,
                                CorCarta = "Verde"
                            },
                            QuantidadeCopiasDaCartaNoBaralho = 1
                        },
                        new CopiaDeCartasNoBaralho
                        {
                            IdCarta = 3,
                            Carta = new Carta()
                            {
                                Id = 3,
                                NomeCarta = "Floresta",
                                CustoDeManaConvertidoCarta = 0,
                                TipoDeCarta = "Basic Land",
                                RaridadeCarta = RaridadeEnum.Comum,
                                PrecoCarta = 0.5m,
                                CorCarta = ""
                            },
                            QuantidadeCopiasDaCartaNoBaralho = 99
                        }
                    },
                    QuantidadeDeCartasNoBaralho = 100,
                    DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                    PrecoDoBaralho = 54.5m,
                    CustoDeManaConvertidoDoBaralho = 0,
                    CorBaralho = "Verde"
                },
                new Baralho()
                {
                    IdJogador = 6,
                    NomeBaralho = "Niv-Mizzet Combo",
                    FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander,
                    CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                    {
                        new CopiaDeCartasNoBaralho ()
                        {
                            IdCarta = 1,
                            Carta = new Carta()
                            {
                                Id = 1,
                                NomeCarta = "Ilha",
                                CustoDeManaConvertidoCarta = 0,
                                TipoDeCarta = "Basic Land",
                                RaridadeCarta = RaridadeEnum.Comum,
                                PrecoCarta = 0.5m,
                                CorCarta = ""
                            },
                            QuantidadeCopiasDaCartaNoBaralho = 49
                        },
                        new CopiaDeCartasNoBaralho ()
                        {
                            IdCarta = 5,
                            Carta = new Carta()
                            {
                                Id = 5,
                                NomeCarta = "Montanha",
                                CustoDeManaConvertidoCarta = 0,
                                TipoDeCarta = "Basic Land",
                                RaridadeCarta = RaridadeEnum.Comum,
                                PrecoCarta = 0.5m,
                                CorCarta = ""
                            },
                            QuantidadeCopiasDaCartaNoBaralho = 50
                        },
                        new CopiaDeCartasNoBaralho ()
                        {
                            IdCarta = 6,
                            Carta = new Carta()
                            {
                                Id = 6,
                                NomeCarta = "Niv-Mizzet, Parum",
                                CustoDeManaConvertidoCarta = 6,
                                TipoDeCarta = "Creature",
                                RaridadeCarta = RaridadeEnum.Raro,
                                PrecoCarta = 5m,
                                CorCarta = "Azul, Vermelho"
                            },
                            QuantidadeCopiasDaCartaNoBaralho = 1
                        }
                    },
                    QuantidadeDeCartasNoBaralho = 100,
                    DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                    PrecoDoBaralho = 54.5m,
                    CustoDeManaConvertidoDoBaralho = 0,
                    CorBaralho = "Azul, Vermelho"
                },
                new Baralho()
                {
                    IdJogador = 7,
                    NomeBaralho = "Mono Green Stomp",
                    FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                    CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                    {
                        new CopiaDeCartasNoBaralho()
                        {

                            IdCarta = 3,
                            Carta = new Carta()
                            {
                                Id = 3,
                                NomeCarta = "Floresta",
                                CustoDeManaConvertidoCarta = 0,
                                TipoDeCarta = "Basic Land",
                                RaridadeCarta = RaridadeEnum.Comum,
                                PrecoCarta = 0.5m,
                                CorCarta = ""
                            },
                            QuantidadeCopiasDaCartaNoBaralho = 60
                        }
                    },
                    QuantidadeDeCartasNoBaralho = 60,
                    DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                    PrecoDoBaralho = 30,
                    CustoDeManaConvertidoDoBaralho = 0,
                    CorBaralho = ""
                }
            };

            foreach (var baralho in listaBaralhosMock)
            {
                var idBaralho = servicoBaralho.Criar(
                    new Baralho()
                    {
                        IdJogador = baralho.IdJogador,
                        NomeBaralho = baralho.NomeBaralho,
                        FormatoDeJogoBaralho = baralho.FormatoDeJogoBaralho,
                        DataDeCriacaoBaralho = baralho.DataDeCriacaoBaralho,
                        CartasDoBaralho = baralho.CartasDoBaralho.ToList()
                    }
                );

                foreach (var copia in baralho.CartasDoBaralho)
                {
                    copia.IdBaralho = idBaralho;
                    servicoBaralho.CriarCopiaDeCartas(copia);
                }
            }
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
                Id = 2,
                IdJogador = 6,
                NomeBaralho = "Niv-Mizzet Combo",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                    {
                        new CopiaDeCartasNoBaralho ()
                        {
                            IdCarta = 1,
                            Carta = new Carta()
                            {
                                Id = 1,
                                NomeCarta = "Ilha",
                                CustoDeManaConvertidoCarta = 0,
                                TipoDeCarta = "Basic Land",
                                RaridadeCarta = RaridadeEnum.Comum,
                                PrecoCarta = 0.5m,
                                CorCarta = ""
                            },
                            QuantidadeCopiasDaCartaNoBaralho = 49
                        },
                        new CopiaDeCartasNoBaralho ()
                        {
                            IdCarta = 5,
                            Carta = new Carta()
                            {
                                Id = 5,
                                NomeCarta = "Montanha",
                                CustoDeManaConvertidoCarta = 0,
                                TipoDeCarta = "Basic Land",
                                RaridadeCarta = RaridadeEnum.Comum,
                                PrecoCarta = 0.5m,
                                CorCarta = ""
                            },
                            QuantidadeCopiasDaCartaNoBaralho = 50
                        },
                        new CopiaDeCartasNoBaralho ()
                        {
                            IdCarta = 6,
                            Carta = new Carta()
                            {
                                Id = 6,
                                NomeCarta = "Niv-Mizzet, Parum",
                                CustoDeManaConvertidoCarta = 6,
                                TipoDeCarta = "Creature",
                                RaridadeCarta = RaridadeEnum.Raro,
                                PrecoCarta = 5m,
                                CorCarta = "Azul, Vermelho"
                            },
                            QuantidadeCopiasDaCartaNoBaralho = 1
                        }
                    },
                QuantidadeDeCartasNoBaralho = 100,
                DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                PrecoDoBaralho = 54.5m,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = "Azul, Vermelho"
            };

            servicoBaralho.ObterTodos(null);

            var baralhoMock = servicoBaralho.ObterPorId(baralhoTeste.Id);

            Assert.Equal(baralhoTeste.NomeBaralho, baralhoMock.NomeBaralho);
            Assert.Equal(baralhoTeste.IdJogador, baralhoMock.IdJogador);
            Assert.Equal(baralhoTeste.CorBaralho, baralhoMock.CorBaralho);
            Assert.Equal(baralhoTeste.QuantidadeDeCartasNoBaralho, baralhoMock.QuantidadeDeCartasNoBaralho);
            Assert.Equal(baralhoTeste.CustoDeManaConvertidoDoBaralho, baralhoMock.CustoDeManaConvertidoDoBaralho);
            Assert.Equal(baralhoTeste.PrecoDoBaralho, baralhoMock.PrecoDoBaralho);
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
                Id = 3,
                IdJogador = -1,
                NomeBaralho = "Mono Green Stomp Pauper",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho
                    {
                        IdCarta = 3,
                        Carta = new Carta()
                        {
                            Id = 3,
                            NomeCarta = "Floresta",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = "Basic Land",
                            RaridadeCarta = RaridadeEnum.Comum,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = ""
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 60
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = ""
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Criar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_nome_vazio_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "Campo nome de baralho n�o pode ser vazio";

            var baralhoTeste = new Baralho()
            {
                Id = 3,
                IdJogador = 1,
                NomeBaralho = "",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho
                    {
                        Carta = new Carta()
                        {
                            Id = 3,
                            NomeCarta = "Floresta",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = "Basic Land",
                            RaridadeCarta = RaridadeEnum.Comum,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = ""
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 60
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = ""
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Criar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_cartas_do_baralho_vazia_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "O baralho deve possuir uma lista de cartas n�o vazia";

            var baralhoTeste = new Baralho()
            {
                Id = 3,
                IdJogador = 1,
                NomeBaralho = "Mono Green Stomp Pauper",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>(),
                QuantidadeDeCartasNoBaralho = 0,
                PrecoDoBaralho = 0,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = ""
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Criar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(0)]
        public void ao_Criar_commmander_com_mais_de_uma_copia_de_carta_nao_terreno_deve_retornar_Exception(int quantidadeDeCartasTeste)
        {
            const string mensagemDeErroEsperada = "Quantidade de cartas do baralho n�o compativel com o formato de jogo selecionado";

            var baralhoTeste = new Baralho()
            {
                Id = 3,
                IdJogador = 1,
                NomeBaralho = "Mono Green Stomp Commander",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho
                    {
                        Carta = new Carta()
                        {
                            Id = 10,
                            NomeCarta = "Sol Ring",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = "Artiact",
                            RaridadeCarta = RaridadeEnum.Comum,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = ""
                        },
                        QuantidadeCopiasDaCartaNoBaralho = quantidadeDeCartasTeste
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = ""
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Criar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Theory]
        [InlineData(99)]
        [InlineData(101)]
        public void ao_Criar_commmander_com_quantidade_de_cartas_no_baralho_diferente_de_cem_cartas_deve_retornar_Exception(int quantidadeDeCartasTeste)
        {
            const string mensagemDeErroEsperada = "Quantidade de cartas do baralho n�o compativel com o formato de jogo selecionado";

            var baralhoTeste = new Baralho()
            {
                Id = 3,
                IdJogador = 1,
                NomeBaralho = "Mono Green Stomp Commander",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho
                    {
                        Carta = new Carta()
                        {
                            Id = 3,
                            NomeCarta = "Floresta",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = "Basic Land",
                            RaridadeCarta = RaridadeEnum.Comum,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = ""
                        },
                        QuantidadeCopiasDaCartaNoBaralho = quantidadeDeCartasTeste
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = ""
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Criar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Theory]
        [InlineData(FormatoDeJogoEnum.Pauper)]
        [InlineData(FormatoDeJogoEnum.Standard)]
        public void ao_Criar_com_quantidade_de_cartas_nao_compativel_com_o_tipo_de_jogo_pauper_ou_standard_deve_retornar_Exception(FormatoDeJogoEnum formatoDeJogoTeste)
        {
            const string mensagemDeErroEsperada = "Quantidade de cartas do baralho n�o compativel com o formato de jogo selecionado";

            var baralhoTeste = new Baralho()
            {
                Id = 3,
                IdJogador = 1,
                NomeBaralho = "Mono Green Stomp",
                FormatoDeJogoBaralho = formatoDeJogoTeste,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho
                    {
                        Carta = new Carta()
                        {
                            Id = 3,
                            NomeCarta = "Floresta",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = "Basic Land",
                            RaridadeCarta = RaridadeEnum.Comum,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = ""
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 59
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = ""
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
                Id = 3,
                IdJogador = 1,
                NomeBaralho = "Mono Green Pauper",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho
                    {
                        Carta = new Carta()
                        {
                            Id = 3,
                            NomeCarta = "Floresta",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = "Basic Land",
                            RaridadeCarta = RaridadeEnum.Comum,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = ""
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 60
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = ""
            };

            servicoBaralho.Criar(baralhoTeste);

            Assert.Equivalent(baralhoTeste, servicoBaralho.ObterPorId(baralhoTeste.Id));
        }

        [Fact]
        public void ao_Atualizar_com_dados_validos_deve_adicionar_atualizar_baralho()
        {
            var dataDeHoje = DateTime.Now;

            var baralhoTeste = new Baralho()
            {
                Id = 3,
                IdJogador = 7,
                NomeBaralho = "Mono Green Stomp",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                    {
                        new CopiaDeCartasNoBaralho()
                        {
                            Carta = new Carta()
                            {
                                Id = 3,
                                NomeCarta = "Floresta",
                                CustoDeManaConvertidoCarta = 0,
                                TipoDeCarta = "Basic Land",
                                RaridadeCarta = RaridadeEnum.Comum,
                                PrecoCarta = 0.5m,
                                CorCarta = ""
                            },
                            QuantidadeCopiasDaCartaNoBaralho = 60
                        }
                    },
                QuantidadeDeCartasNoBaralho = 60,
                DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = ""
            };

            servicoBaralho.Atualizar(baralhoTeste);

            Assert.Equivalent(baralhoTeste, servicoBaralho.ObterPorId(baralhoTeste.Id));
        }

        [Theory]
        [InlineData(FormatoDeJogoEnum.Standard)]
        [InlineData(FormatoDeJogoEnum.Pauper)]
        [InlineData(FormatoDeJogoEnum.Commander)]
        public void ao_Atualizar_com_baralho_invalido_deve_retornar_Exception(FormatoDeJogoEnum formatoDeJogoBaralhoTeste)
        {
            const string mensagemDeErroEsperada = ("Quantidade de cartas do baralho n�o compativel com o formato de jogo selecionado");

            var dataDeHoje = DateTime.Now;

            var baralhoTeste = new Baralho()
            {
                Id = 1,
                IdJogador = 1,
                NomeBaralho = "Mono Green Stomp",
                FormatoDeJogoBaralho = formatoDeJogoBaralhoTeste,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho
                    {
                        Carta = new Carta()
                        {
                            Id = 7,
                            NomeCarta = "Ghalta, Fome Primordial",
                            CustoDeManaConvertidoCarta = 12,
                            TipoDeCarta = "Creature",
                            RaridadeCarta = RaridadeEnum.Comum,
                            PrecoCarta = Convert.ToDecimal(5),
                            CorCarta = "Verde"
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 1
                    },
                    new CopiaDeCartasNoBaralho
                    {
                        Carta = new Carta()
                        {
                            Id = 3,
                            NomeCarta = "Floresta",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = "Basic Land",
                            RaridadeCarta = RaridadeEnum.Comum,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = ""
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 20
                    }
                },
                QuantidadeDeCartasNoBaralho = 21,
                DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                PrecoDoBaralho = 54.5m,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = "Verde"
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Atualizar(baralhoTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(10)]
        public void ao_Atualizar_com_id_invalido_ou_inexistente_deve_retornar_Exception(int idBaralhoTeste)
        {
            var mensagemDeErroEsperada = ($"Baralho {idBaralhoTeste} Nao Encontrado");

            var baralhoTeste = new Baralho()
            {
                Id = idBaralhoTeste,
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
                Id = 3,
                IdJogador = 7,
                NomeBaralho = "Mono Green Stomp",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho()
                    {
                        Carta = new Carta()
                        {
                            Id = 3,
                            NomeCarta = "Floresta",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = "Basic Land",
                            RaridadeCarta = RaridadeEnum.Comum,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = ""
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 56
                    },
                    new CopiaDeCartasNoBaralho()
                    {
                        Carta = new Carta()
                        {
                            Id = 6,
                            NomeCarta = "Elfos de Llanowar",
                            CustoDeManaConvertidoCarta = 1,
                            TipoDeCarta = "Creature",
                            RaridadeCarta = RaridadeEnum.Comum,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = "Verde"
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 4
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                DataDeCriacaoBaralho = new DateTime(dataDeHoje.Year, dataDeHoje.Month, dataDeHoje.Day),
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = "Verde"
            };

            var baralhoTesteExistente = servicoBaralho.ObterPorId(baralhoTeste.Id);

            servicoBaralho.Atualizar(baralhoTeste);

            Assert.Equal(baralhoTesteExistente.Id, servicoBaralho.ObterPorId(baralhoTeste.Id).Id);
            Assert.Equal(baralhoTesteExistente.IdJogador, servicoBaralho.ObterPorId(baralhoTeste.Id).IdJogador);
        }

        [Fact]
        public void ao_Atualizar_com_cartas_do_baralho_vazia_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "O baralho deve possuir uma lista de cartas n�o vazia";

            var baralhoTeste = new Baralho()
            {
                Id = 1,
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
            const string mensagemDeErroEsperada = "Campo nome de baralho n�o pode ser vazio";

            var baralhoTeste = new Baralho()
            {
                Id = 1,
                IdJogador = 1,
                NomeBaralho = "",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho
                    {
                        Carta = new Carta()
                        {
                            Id = 7,
                            NomeCarta = "Ghalta, Fome Primordial",
                            CustoDeManaConvertidoCarta = 12,
                            TipoDeCarta = "Creature",
                            RaridadeCarta = RaridadeEnum.Raro,
                            PrecoCarta = Convert.ToDecimal(5),
                            CorCarta = "Verde"
                        },
                        QuantidadeCopiasDaCartaNoBaralho = 1
                    },
                    new CopiaDeCartasNoBaralho
                    {
                        Carta = new Carta()
                        {
                            Id = 3,
                            NomeCarta = "Floresta",
                            CustoDeManaConvertidoCarta = 0,
                            TipoDeCarta = "Basic Land",
                            RaridadeCarta = RaridadeEnum.Comum,
                            PrecoCarta = Convert.ToDecimal(0.5),
                            CorCarta = ""
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
                Id = idBaralhoTeste,
            };

            var resultado = Assert.Throws<Exception>(() => servicoBaralho.Excluir(baralhoTeste.Id));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_ObterTodos_com_filtro_deve_retornar_lista_filtrada_por_FormatoDeJogo()
        {
            var listaFiltroFormatoDeJogo = servicoBaralho.ObterTodos(new BaralhoFiltro() { FormatoDeJogoBaralho = new List<FormatoDeJogoEnum>() { FormatoDeJogoEnum.Commander } });

            const FormatoDeJogoEnum formatoDeJogoEsperado = FormatoDeJogoEnum.Commander;

            listaFiltroFormatoDeJogo.ForEach(baralho => Assert.Equal(formatoDeJogoEsperado, baralho.FormatoDeJogoBaralho));
        }
    }
}