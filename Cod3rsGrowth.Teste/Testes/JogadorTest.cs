using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Infra.Repository.RepositoryJogador;
using Cod3rsGrowth.Servicos.ServicoJogador;
using FluentValidation;
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
                    BaralhosJogador = new List<Baralho>()
                },
                new Jogador()
                {
                    IdJogador = 2,
                    NomeJogador = "Paulo",
                    DataNascimentoJogador = new DateTime(day: 9, month: 3, year: 1999),
                    PrecoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = new List < Baralho >()
                },
                new Jogador()
                {
                    IdJogador = 3,
                    NomeJogador = "Silva",
                    DataNascimentoJogador = new DateTime(day: 10, month: 3, year: 1999),
                    PrecoDasCartasJogador = 0,
                    QuantidadeDeBaralhosJogador = 0,
                    ContaAtivaJogador = true,
                    BaralhosJogador = new List<Baralho>()
                }
            };

            ObterServico.ObterTodos().Clear();

            listaJogadoresMock.ForEach(jogador => ObterServico.Criar(new Jogador()
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
                BaralhosJogador = new List<Baralho>()
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

            var resultado = Assert.Throws<Exception>(() => ObterServico.Criar(jogadorTeste));

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

            var resultado = Assert.Throws<Exception>(() => ObterServico.Criar(jogadorTeste));

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

            var resultado = Assert.Throws<Exception>(() => ObterServico.Criar(jogadorTeste));

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

            ObterServico.Criar(jogadorTeste);

            Assert.Equal(jogadorTeste, ObterServico.ObterPorId(jogadorTeste.IdJogador));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void ao_Atualizar_com_dados_validos_deve_adicionar_um_novo_jogador(int idJogadorTeste)
        {
            var dataDeHoje = DateTime.Now;

            var baralhoTesteJogador = new List<Baralho>()
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
                }
            };

            var jogadorTeste = ObterServico.ObterPorId(idJogadorTeste);

            jogadorTeste.BaralhosJogador = baralhoTesteJogador;

            ObterServico.Atualizar(jogadorTeste);

            Assert.Equivalent(jogadorTeste, ObterServico.ObterPorId(idJogadorTeste));
        }

        [Theory]
        [InlineData(FormatoDeJogoEnum.Standard)]
        [InlineData(FormatoDeJogoEnum.Pauper)]
        [InlineData(FormatoDeJogoEnum.Commander)]
        public void ao_Atualizar_com_baralho_invalido_deve_retornar_Exception(FormatoDeJogoEnum formatoDeJogoBaralhoJogadorTeste)
        {
            const string mensagemDeErroEsperada = ("Quantidade de cartas do baralho não compativel com o formato de jogo selecionado");

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

            var resultado = Assert.Throws<Exception>(() => ObterServico.Atualizar(jogadorTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        public void ao_Atualizar_com_id_invalido_ou_inexistente_deve_retornar_Exception(int idJogadorTeste)
        {
            var mensagemDeErroEsperada = ($"Jogador {idJogadorTeste} Nao Encontrado");

            var jogadorTeste = new Jogador()
            {
                IdJogador = idJogadorTeste,
            };

            var resultado = Assert.Throws<Exception>(() => ObterServico.Atualizar(jogadorTeste));

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

            var jogadorTesteExistente = ObterServico.ObterPorId(jogadorTeste.IdJogador);

            ObterServico.Atualizar(jogadorTeste);

            Assert.Equal(jogadorTesteExistente.NomeJogador, ObterServico.ObterPorId(jogadorTeste.IdJogador).NomeJogador);
            Assert.Equal(jogadorTesteExistente.DataNascimentoJogador, ObterServico.ObterPorId(jogadorTeste.IdJogador).DataNascimentoJogador);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void ao_Excluir_com_id_valido_deve_remover_o_jogador_correspondente(int idJogadorTeste)
        {
            var mensagemDeErroEsperada = ($"Jogador {idJogadorTeste} Nao Encontrado");

            var jogadorTeste = new Jogador()
            {
                IdJogador = idJogadorTeste,
            };

            ObterServico.Excluir(jogadorTeste);

            var resultado = Assert.Throws<Exception>(() => ObterServico.ObterPorId(jogadorTeste.IdJogador));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(10)]
        public void ao_Excluir_com_um_id_invalido_ou_inexistente_deve_retornar_Exception(int idJogadorTeste)
        {
            var mensagemDeErroEsperada = ($"Jogador {idJogadorTeste} Nao Encontrado");

            var jogadorTeste = new Jogador()
            {
                IdJogador = idJogadorTeste,
            };

            var resultado = Assert.Throws<Exception>(() => ObterServico.Excluir(jogadorTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }
    }
}