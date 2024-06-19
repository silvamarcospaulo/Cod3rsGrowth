using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;
using Microsoft.Extensions.DependencyInjection;
using Cod3rsGrowth.Servico.ServicoCarta;
using System.Diagnostics.Metrics;

namespace Cod3rsGrowth.Teste.Testes
{
    public class CartaTest : TesteBase
    {
        private readonly CartaServico ObterServico;
        public CartaTest()
        {
            ObterServico = ServiceProvider.GetService<CartaServico>() ?? throw new Exception("Erro ao obter servico");
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

            ObterServico.ObterTodos(null).Clear();

            listaCartasMock.ForEach(carta => ObterServico.Criar(
                new Carta()
                {
                    NomeCarta = carta.NomeCarta,
                    CustoDeManaConvertidoCarta = carta.CustoDeManaConvertidoCarta,
                    TipoDeCarta = carta.TipoDeCarta,
                    RaridadeCarta = carta.RaridadeCarta,
                    CorCarta = carta.CorCarta
                }));
        }

        [Fact]
        public void ao_ObterTodos_verifica_se_a_lista_nao_esta_vazia()
        {
            IniciarListaMock();

            var cartas = ObterServico.ObterTodos(null);

            Assert.NotEmpty(cartas);
        }

        [Fact]
        public void ao_ObterTodos_deve_retornar_uma_lista_com_sete_cartas()
        {
            const int quantidadeDeCartasEsperadas = 7;

            var quantidadeDeCartasMock = ObterServico.ObterTodos(null).Count();

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
                CorCarta = new List<CoresEnum>() { CoresEnum.Azul, CoresEnum.Vermelho }
            };

            var cartaMock = ObterServico.ObterPorId(cartaTeste.IdCarta);

            Assert.Equivalent(cartaTeste, cartaMock);
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(8)]
        public void ao_ObterPorId_invalido_ou_inexistente_deve_retornar_Exception(int idCartaTeste)
        {
            Assert.Throws<Exception>(() => ObterServico.ObterPorId(idCartaTeste));
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
                CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
            };

            var resultado = Assert.Throws<Exception>(() => ObterServico.Criar(cartaTeste));

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
                CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
            };

            var resultado = Assert.Throws<Exception>(() => ObterServico.Criar(cartaTeste));

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
                CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
            };

            ObterServico.Criar(cartaTeste);

            Assert.Equivalent(cartaTeste, ObterServico.ObterPorId(cartaTeste.IdCarta));
        }

        [Fact]
        public void ao_Atualizar_com_dados_validos_deve_adicionar_uma_nova_carta()
        {
            var cartaTeste = new Carta()
            {
                IdCarta = 7,
                RaridadeCarta = RaridadeEnum.Uncommon,
            };

            var precoCartaEsperado = 2.5m;

            ObterServico.Atualizar(cartaTeste);

            Assert.Equal(precoCartaEsperado, ObterServico.ObterPorId(cartaTeste.IdCarta).PrecoCarta);
            Assert.Equal(cartaTeste.RaridadeCarta, ObterServico.ObterPorId(cartaTeste.IdCarta).RaridadeCarta);
        }

        [Fact]
        public void ao_Atualizar_com_nao_deve_ser_alterar_nome_custo_de_mana_convertido_tipo_de_carta_e_cor_carta()
        {
            var cartaTeste = new Carta()
            {
                IdCarta = 1,
                NomeCarta = "Ilha",
                CustoDeManaConvertidoCarta = 0,
                TipoDeCarta = TipoDeCartaEnum.TerrenoBasico,
                RaridadeCarta = RaridadeEnum.Uncommon,
                PrecoCarta = Convert.ToDecimal(2.5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
            };


            var cartaTesteExistente = new Carta()
            {
                IdCarta = ObterServico.ObterPorId(cartaTeste.IdCarta).IdCarta,
                NomeCarta = ObterServico.ObterPorId(cartaTeste.IdCarta).NomeCarta,
                CustoDeManaConvertidoCarta = ObterServico.ObterPorId(cartaTeste.IdCarta).CustoDeManaConvertidoCarta,
                TipoDeCarta = ObterServico.ObterPorId(cartaTeste.IdCarta).TipoDeCarta,
                RaridadeCarta = ObterServico.ObterPorId(cartaTeste.IdCarta).RaridadeCarta,
                PrecoCarta = ObterServico.ObterPorId(cartaTeste.IdCarta).PrecoCarta,
                CorCarta = ObterServico.ObterPorId(cartaTeste.IdCarta).CorCarta,
            };

            ObterServico.Atualizar(cartaTeste);

            var cartaTesteAtualizada = ObterServico.ObterPorId(cartaTeste.IdCarta);

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
        [InlineData(8)]
        public void ao_Atualizar_invalido_ou_inexistente_deve_retornar_Exception(int idCartaTeste)
        {
            var mensagemDeErroEsperada = ($"Carta {idCartaTeste} Nao Encontrada");

            var cartaTeste = new Carta()
            {
                IdCarta = idCartaTeste,
            };

            var resultado = Assert.Throws<Exception>(() => ObterServico.Atualizar(cartaTeste));

            Assert.Equal(mensagemDeErroEsperada, resultado.Message);
        }
    }
}