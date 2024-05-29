using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryBaralho;
using Microsoft.Extensions.DependencyInjection;
using System;
using Cod3rsGrowth.Teste.Singleton;

namespace Cod3rsGrowth.Teste.Testes
{
    public class BaralhoTest : TesteBase
    {
        private readonly IBaralhoRepository ObterServico;
        private List<Baralho> _listaBaralho;
        private List<Baralho> _listaBaralhoMock;

        public BaralhoTest()
        {
            ObterServico = ServiceProvider.GetService<IBaralhoRepository>() ?? throw new Exception($"Erro ao obter servico");
        }

        [Fact]
        public void verifica_se_a_lista_esta_vazia()
        {
            var baralhos = ObterServico.ObterTodos();

            Assert.NotEmpty(baralhos);
        }

        [Fact]
        public void verifica_se_o_metodo_retorna_todas_as_cartas()
        {
            List<Baralho> listaDeBaralhos = new List<Baralho>()
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
                                IdCarta = 10,
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
                    PrecoDoBaralho = 54.5m,
                    CustoDeManaConvertidoDoBaralho = 12,
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
                    PrecoDoBaralho = 54.5m,
                    CustoDeManaConvertidoDoBaralho = 6,
                    CorBaralho = new List<CoresEnum>() {CoresEnum.Azul, CoresEnum.Vermelho}
                }
            };

            var baralhos = ObterServico.ObterTodos();

            Assert.Equivalent(listaDeBaralhos, baralhos);
        }
    }
}