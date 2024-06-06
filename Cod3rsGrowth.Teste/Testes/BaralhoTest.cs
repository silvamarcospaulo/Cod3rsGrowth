using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;
using Microsoft.Extensions.DependencyInjection;
using System;
using Cod3rsGrowth.Servico.ServicoBaralho;

namespace Cod3rsGrowth.Teste.Testes
{
    public class BaralhoTest : TesteBase
    {
        private readonly IServicoBaralho ObterServico;

        public BaralhoTest()
        {
            ObterServico = ServiceProvider.GetService<IServicoBaralho>() ?? throw new Exception($"Erro ao obter servico");
            IniciarListaMock();
        }

        public void IniciarListaMock()
        {
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

            ObterServico.ObterTodos().Clear(); 
            
            listaBaralhosMock.ForEach(baralho => ObterServico.Inserir(baralho));
        }

        [Fact]
        public void verifica_se_a_lista_nao_esta_vazia()
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
            var baralhoTeste = new Baralho()
            {
                IdBaralho = 2,
                IdJogador = 1,
                NomeBaralho = "Niv-Mizzet Combo",
                FormatoDeJogoBaralho = FormatoDeJogoEnum.Commander,
                CartasDoBaralho = new List<CopiaDeCartasNoBaralho>()
                {
                    new CopiaDeCartasNoBaralho()
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
                    new CopiaDeCartasNoBaralho()
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
                    new CopiaDeCartasNoBaralho()
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
                CorBaralho = new List<CoresEnum>() { CoresEnum.Azul, CoresEnum.Vermelho }
            };

            var baralhoMock = ObterServico.ObterPorId(baralhoTeste.IdBaralho);

            Assert.Equivalent(baralhoTeste, baralhoMock);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(-2)]
        public void ao_ObterPorId_invalido_ou_inexistente_deve_retornar_Exception(int idBaralhoTeste)
        {
            Assert.Throws<Exception>(() => { ObterServico.ObterPorId(idBaralhoTeste); });
        }
    }
}