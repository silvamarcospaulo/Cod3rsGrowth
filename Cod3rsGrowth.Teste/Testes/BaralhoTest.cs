using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;
using Microsoft.Extensions.DependencyInjection;
using System;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;

namespace Cod3rsGrowth.Teste.Testes
{
    public class BaralhoTest : TesteBase
    {
        private readonly ServicoBaralho ObterServico;

        public BaralhoTest()
        {
            ObterServico = ServiceProvider.GetService<ServicoBaralho>() ?? throw new Exception($"Erro ao obter servico");
            IniciarListaMock();
        }

        private void IniciarListaMock()
        {
            DateTime dataDeHoje = DateTime.Now;

            List<Baralho> listaBaralhosMock = new List<Baralho>()
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
                }
            };

            ObterServico.ObterTodos().Clear();

            listaBaralhosMock.ForEach(baralho => ObterServico.CriarBaralho(new Baralho()
            {
                IdBaralho = baralho.IdBaralho,
                IdJogador = baralho.IdJogador,
                NomeBaralho = baralho.NomeBaralho,
                FormatoDeJogoBaralho = baralho.FormatoDeJogoBaralho,
                CartasDoBaralho = baralho.CartasDoBaralho,
                QuantidadeDeCartasNoBaralho = baralho.QuantidadeDeCartasNoBaralho,
                PrecoDoBaralho = baralho.PrecoDoBaralho,
                CustoDeManaConvertidoDoBaralho = baralho.CustoDeManaConvertidoDoBaralho,
                CorBaralho = baralho.CorBaralho
            }));
        }

        [Fact]
        public void ao_ObterTodos_verifica_se_a_lista_nao_esta_vazia()
        {
            var baralhos = ObterServico.ObterTodos();

            Assert.NotEmpty(baralhos);
        }

        [Fact]
        public void ao_ObterTodos_deve_retornar_uma_lista_com_dois_baralhos()
        {
            const int quantidadeDeBaralhosEsperados = 2;

            var quantidadeDeBaralhos = ObterServico.ObterTodos().Count();

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

            var baralhoMock = ObterServico.ObterPorId(baralhoTeste.IdBaralho);

            Assert.Equivalent(baralhoTeste, baralhoMock);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(-2)]
        public void ao_ObterPorId_invalido_ou_inexistente_deve_retornar_Exception(int idBaralhoTeste)
        {
            Assert.Throws<Exception>(() => ObterServico.ObterPorId(idBaralhoTeste));
        }

        [Fact]
        public void ao_CriarBaralho_com_idJogador_negativo_deve_retornar_Exception()
        {
            const string mensagemEsperada = "Campo Id do jogador tem quer ser maior do que Um";

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

            var resultado = ObterServico.CriarBaralho(baralhoTeste);

            var mensagemDeErro = resultado.Errors.FirstOrDefault(e => e.PropertyName == "IdJogador")?.ErrorMessage;

            Assert.Equal(mensagemEsperada, mensagemDeErro);
        }

        [Fact]
        public void ao_CriarBaralho_com_nome_vazio_deve_retornar_Exception()
        {
            const string mensagemEsperada = "Campo nome de baralho não pode ser vazio";

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

            var resultado = ObterServico.CriarBaralho(baralhoTeste);

            var mensagemDeErro = resultado.Errors.FirstOrDefault(e => e.PropertyName == "NomeBaralho")?.ErrorMessage;

            Assert.Equal(mensagemEsperada, mensagemDeErro);
        }

        [Fact]
        public void ao_CriarBaralho_com_cartas_do_baralho_vazia_deve_retornar_Exception()
        {
            const string mensagemEsperada = "O baralho deve possuir uma lista de cartas não vazia";

            var baralhoTeste = new Baralho()
            {
                IdBaralho = 3,
                IdJogador = -1,
                NomeBaralho = "Mono Green Stomp Pauper",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Pauper,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>(),
                QuantidadeDeCartasNoBaralho = 60,
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = new List<CoresEnum>() { CoresEnum.Incolor }
            };

            var resultado = ObterServico.CriarBaralho(baralhoTeste);

            var mensagemDeErro = resultado.Errors.FirstOrDefault(e => e.PropertyName == "CartasDoBaralho")?.ErrorMessage;

            Assert.Equal(mensagemEsperada, mensagemDeErro);
        }
        
        [Theory]
        [InlineData(2)]
        [InlineData(0)]
        public void ao_CriarBaralho_commmander_com_mais_de_uma_copia_de_carta_nao_terreno_deve_retornar_Exception(int quantidadeDeCartasTeste)
        {
            const string mensagemEsperada = "Quantidade de cartas do baralho não compativel com o formato de jogo selecionado";

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
                        QuantidadeCopiasDaCartaNoBaralho = 100
                    }
                },
                QuantidadeDeCartasNoBaralho = 60,
                PrecoDoBaralho = 30,
                CustoDeManaConvertidoDoBaralho = 0,
                CorBaralho = new List<CoresEnum>() { CoresEnum.Incolor }
            };

            var resultado = ObterServico.CriarBaralho(baralhoTeste);

            var mensagemDeErro = resultado.Errors.FirstOrDefault()?.ErrorMessage;

            Assert.Equal(mensagemEsperada, mensagemDeErro);
        }

        [Theory]
        [InlineData(99)]
        [InlineData(101)]
        public void ao_CriarBaralho_commmander_com_quantidade_de_cartas_no_baralho_diferente_de_cem_cartas_deve_retornar_Exception(int quantidadeDeCartasTeste)
        {
            const string mensagemEsperada = "Quantidade de cartas do baralho não compativel com o formato de jogo selecionado";

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

            var resultado = ObterServico.CriarBaralho(baralhoTeste);

            var mensagemDeErro = resultado.Errors.FirstOrDefault()?.ErrorMessage;

            Assert.Equal(mensagemEsperada, mensagemDeErro);
        }

        [Theory]
        [InlineData(FormatoDeJogoEnum.Pauper)]
        [InlineData(FormatoDeJogoEnum.Standard)]
        public void ao_CriarBaralho_com_quantidade_de_cartas_nao_compativel_com_o_tipo_de_jogo_pauper_ou_standard_deve_retornar_Exception(FormatoDeJogoEnum formatoDeJogoTeste)
        {
            const string mensagemEsperada = "Quantidade de cartas do baralho não compativel com o formato de jogo selecionado";

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

            var resultado = ObterServico.CriarBaralho(baralhoTeste);

            var mensagemDeErro = resultado.Errors.FirstOrDefault()?.ErrorMessage;

            Assert.Equal(mensagemEsperada, mensagemDeErro);
        }

        [Fact]
        public void ao_CriarBaralho_com_dados_validos_deve_adicionar_ao_banco_de_dados()
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

            ObterServico.CriarBaralho(baralhoTeste);

            Assert.Equivalent(baralhoTeste, ObterServico.ObterPorId(ObterServico.ObterTodos().Count()));
        }
    }
}