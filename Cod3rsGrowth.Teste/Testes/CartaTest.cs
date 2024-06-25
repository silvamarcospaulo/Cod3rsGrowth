using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;
using Microsoft.Extensions.DependencyInjection;
using Cod3rsGrowth.Servico.ServicoCarta;
using System.Diagnostics.Metrics;
using Cod3rsGrowth.Dominio.Filtros;
using static LinqToDB.Common.Configuration;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Cod3rsGrowth.Servico.ServicoJogador;
using LinqToDB.Common;
using Cod3rsGrowth.Teste.Singleton;

namespace Cod3rsGrowth.Teste.Testes
{
    public class CartaTest : TesteBase
    {
        private readonly CartaServico servicoCarta;
        private readonly BaralhoServico servicoBaralho;
        private readonly JogadorServico servicoJogador;

        private List<Carta> tabelaCarta = SingletonTabelasTeste.InstanciaCarta;
        private List<CorCarta> tabelaCorCarta = SingletonTabelasTeste.InstanciaCorCarta;
        private List<CorBaralho> tabelaCorBaralho = SingletonTabelasTeste.InstanciaCorBaralho;
        private List<CopiaDeCartasNoBaralho> tabelaCopiaDeCartasNoBaralho = SingletonTabelasTeste.InstanciaCopiaDeCartasNoBaralho;
        private List<Baralho> tabelaBaralho = SingletonTabelasTeste.InstanciaBaralho;
        private List<Jogador> tabelaJogador = SingletonTabelasTeste.InstanciaJogador;

        public CartaTest()
        {
            servicoCarta = ServiceProvider.GetService<CartaServico>() ?? throw new Exception("Erro ao obter servico Carta");

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
            var listaCartasMock = new List<Carta>()
            {
                new Carta()
                {
                    IdCarta = 1,
                    NomeCarta = "Ilha",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                    RaridadeCarta = RaridadeEnum.Common,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                },
                new Carta()
                {
                    IdCarta = 2,
                    NomeCarta = "Pantano",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                    RaridadeCarta = RaridadeEnum.Common,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                },
                new Carta()
                {
                    IdCarta = 3,
                    NomeCarta = "Floresta",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                    RaridadeCarta = RaridadeEnum.Common,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                },
                new Carta()
                {
                    IdCarta = 4,
                    NomeCarta = "Planice",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                    RaridadeCarta = RaridadeEnum.Common,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                },
                new Carta()
                {
                    IdCarta = 5,
                    NomeCarta = "Montanha",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                    RaridadeCarta = RaridadeEnum.Common,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                },
                new Carta()
                {
                    IdCarta = 6,
                    NomeCarta = "Niv-Mizzet, Parum",
                    CustoDeManaConvertidoCarta = 6,
                    TipoDeCarta = TipoDeCartaEnum.Criatura,
                    RaridadeCarta = RaridadeEnum.Rare,
                    PrecoCarta = Convert.ToDecimal(5),
                    CorCarta = new List<CoresEnum>() { CoresEnum.Azul, CoresEnum.Vermelho }
                },
                new Carta()
                {
                    IdCarta = 7,
                    NomeCarta = "Ghalta, Fome Primordial",
                    CustoDeManaConvertidoCarta = 12,
                    TipoDeCarta = TipoDeCartaEnum.Criatura,
                    RaridadeCarta = RaridadeEnum.Rare,
                    PrecoCarta = Convert.ToDecimal(5),
                    CorCarta = new List<CoresEnum>() { CoresEnum.Vermelho }
                }
            };

            var cartas = servicoCarta.ObterTodos(new CartaFiltro());

            if (cartas.IsNullOrEmpty()) listaCartasMock.ForEach(carta => servicoCarta.Criar(carta));
        }

        [Fact]
        public void ao_ObterTodos_verifica_se_a_lista_nao_esta_vazia()
        {
            IniciarListaMock();

            var cartas = servicoCarta.ObterTodos(new CartaFiltro());

            Assert.NotEmpty(cartas);
        }

        [Fact]
        public void ao_ObterTodos_deve_retornar_uma_lista_com_sete_cartas()
        {
            const int quantidadeDeCartasEsperadas = 7;

            var quantidadeDeCartasMock = servicoCarta.ObterTodos(new CartaFiltro()).Count();

            Assert.Equal(quantidadeDeCartasEsperadas, quantidadeDeCartasMock);
        }

        [Fact]
        public void ao_ObterPorId_com_id_seis_retornar_baralho_niv_mizzet_parum()
        {
            var cartaTeste = new Carta()
            {
                IdCarta = 6,
                NomeCarta = "Niv-Mizzet, Parum",
                CustoDeManaConvertidoCarta = 6,
                TipoDeCarta = TipoDeCartaEnum.Criatura,
                RaridadeCarta = RaridadeEnum.Rare,
                PrecoCarta = Convert.ToDecimal(5),
                CorCarta = new List<CoresEnum>()
                    {
                        CoresEnum.Azul,
                        CoresEnum.Vermelho
                    }
            };

            var cartaMock = servicoCarta.ObterPorId(cartaTeste.IdCarta);

            Assert.Equivalent(cartaTeste, cartaMock);
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(8)]
        public void ao_ObterPorId_com_id_invalido_ou_inexistente_deve_retornar_Exception(int idCartaTeste)
        {
            Assert.Throws<Exception>(() => servicoCarta.ObterPorId(idCartaTeste));
        }

        [Fact]
        public void ao_Criar_com_nome_vazio_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "Nome da carta nao pode ser vazio";

            var cartaTeste = new Carta()
            {
                IdCarta = 8,
                NomeCarta = "",
                CustoDeManaConvertidoCarta = 2,
                TipoDeCarta = TipoDeCartaEnum.Artefato,
                RaridadeCarta = RaridadeEnum.Common,
                PrecoCarta = 0.5m,
                CorCarta = new List<CoresEnum>()
                {
                    CoresEnum.Incolor
                }
            };

            var resultado = Assert.Throws<Exception>(() => servicoCarta.Criar(cartaTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_custo_de_mana_convertido_negativo_deve_retornar_Exception()
        {
            const string mensagemDeErroEsperada = "Custo de Mana Convertido da Carta deve ser igual ou maior que 0";

            var cartaTeste = new Carta()
            {
                IdCarta = 8,
                NomeCarta = "Sol Ring",
                CustoDeManaConvertidoCarta = -1,
                TipoDeCarta = TipoDeCartaEnum.Artefato,
                RaridadeCarta = RaridadeEnum.Common,
                PrecoCarta = 0.5m,
                CorCarta = new List<CoresEnum>()
                {
                    CoresEnum.Incolor
                }
            };

            var resultado = Assert.Throws<Exception>(() => servicoCarta.Criar(cartaTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }

        [Fact]
        public void ao_Criar_com_dados_validos_deve_adicionar_uma_nova_carta()
        {
            var cartaTeste = new Carta()
            {
                IdCarta = 8,
                NomeCarta = "Sol Ring",
                CustoDeManaConvertidoCarta = 2,
                TipoDeCarta = TipoDeCartaEnum.Artefato,
                RaridadeCarta = RaridadeEnum.Common,
                PrecoCarta = 0.5m,
                CorCarta = new List<CoresEnum>()
                {
                    CoresEnum.Incolor
                }
            };

            servicoCarta.Criar(cartaTeste);

            Assert.Equivalent(cartaTeste, servicoCarta.ObterPorId(cartaTeste.IdCarta));
        }

        [Fact]
        public void ao_Atualizar_com_dados_validos_deve_atualizar_carta_existente()
        {
            var cartaTeste = new Carta()
            {
                IdCarta = 7,
                RaridadeCarta = RaridadeEnum.Uncommon,
            };

            var precoCartaEsperado = 2.5m;

            servicoCarta.Atualizar(cartaTeste);

            Assert.Equal(precoCartaEsperado, servicoCarta.ObterPorId(cartaTeste.IdCarta).PrecoCarta);
            Assert.Equal(cartaTeste.RaridadeCarta, servicoCarta.ObterPorId(cartaTeste.IdCarta).RaridadeCarta);
        }

        [Fact]
        public void ao_Atualizar_com_dados_validos_nao_deve_alterar_nome_custo_de_mana_convertido_tipo_de_carta_e_cor_carta()
        {
            var cartaTeste = new Carta()
            {
                IdCarta = 1,
                NomeCarta = "Ilha",
                CustoDeManaConvertidoCarta = 0,
                TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                RaridadeCarta = RaridadeEnum.Uncommon,
                PrecoCarta = Convert.ToDecimal(2.5),
                CorCarta = new List<CoresEnum>()
                {
                    CoresEnum.Incolor
                }
            };

            var cartaTesteExistente = new Carta()
            {
                IdCarta = servicoCarta.ObterPorId(cartaTeste.IdCarta).IdCarta,
                NomeCarta = servicoCarta.ObterPorId(cartaTeste.IdCarta).NomeCarta,
                CustoDeManaConvertidoCarta = servicoCarta.ObterPorId(cartaTeste.IdCarta).CustoDeManaConvertidoCarta,
                TipoDeCarta = servicoCarta.ObterPorId(cartaTeste.IdCarta).TipoDeCarta,
                RaridadeCarta = servicoCarta.ObterPorId(cartaTeste.IdCarta).RaridadeCarta,
                PrecoCarta = servicoCarta.ObterPorId(cartaTeste.IdCarta).PrecoCarta,
                CorCarta = servicoCarta.ObterPorId(cartaTeste.IdCarta).CorCarta,
            };

            servicoCarta.Atualizar(cartaTeste);

            var cartaTesteAtualizada = servicoCarta.ObterPorId(cartaTeste.IdCarta);

            Assert.Equal(cartaTesteExistente.IdCarta, cartaTesteAtualizada.IdCarta);
            Assert.Equal(cartaTesteExistente.NomeCarta, cartaTesteAtualizada.NomeCarta);
            Assert.Equal(cartaTesteExistente.CustoDeManaConvertidoCarta, cartaTesteAtualizada.CustoDeManaConvertidoCarta);
            Assert.Equal(cartaTesteExistente.TipoDeCarta, cartaTesteAtualizada.TipoDeCarta);
            Assert.NotEqual(cartaTesteExistente.RaridadeCarta, cartaTesteAtualizada.RaridadeCarta);
            Assert.NotEqual(cartaTesteExistente.PrecoCarta, cartaTesteAtualizada.PrecoCarta);
            Assert.Equal(cartaTesteExistente.CorCarta, cartaTesteAtualizada.CorCarta);
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(292788)]
        public void ao_Atualizar_com_id_invalido_ou_inexistente_deve_retornar_Exception(int idCartaTeste)
        {
            var mensagemDeErroEsperada = ($"Carta {idCartaTeste} Nao Encontrada");

            var cartaTeste = new Carta()
            {
                IdCarta = idCartaTeste,
                NomeCarta = "Sol Ring",
                TipoDeCarta = TipoDeCartaEnum.Artefato,
                CustoDeManaConvertidoCarta = 1,
                RaridadeCarta = RaridadeEnum.Common,
                PrecoCarta = 0.5m,
                CorCarta = new List<CoresEnum>() {CoresEnum.Incolor},
            };

            var resultado = Assert.Throws<Exception>(() => servicoCarta.Atualizar(cartaTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }
    }
}