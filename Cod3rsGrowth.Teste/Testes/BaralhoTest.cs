using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;
using Microsoft.Extensions.DependencyInjection;
using System;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Newtonsoft.Json.Serialization;

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