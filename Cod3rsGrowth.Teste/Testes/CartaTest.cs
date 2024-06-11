using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;
using Microsoft.Extensions.DependencyInjection;
using Cod3rsGrowth.Servico.ServicoCarta;

namespace Cod3rsGrowth.Teste.Testes
{
    public class CartaTest : TesteBase
    {
        private readonly ServicoCarta ObterServico;
        public CartaTest()
        {
            ObterServico = ServiceProvider.GetService<ServicoCarta>() ?? throw new Exception("Erro ao obter servico");
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

            ObterServico.ObterTodos().Clear();

            listaCartasMock.ForEach(carta => ObterServico.CriarCarta(new Carta()
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

            var cartas = ObterServico.ObterTodos();

            Assert.NotEmpty(cartas);
        }
        [Fact]
        public void ao_ObterTodos_deve_retornar_uma_lista_com_sete_cartas()
        {
            const int quantidadeDeCartasEsperadas = 7;

            var quantidadeDeCartasMock = ObterServico.ObterTodos().Count();

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
        public void ao_CriarCarta_com_nome_vazio_deve_retornar_Exception()
        {
            const string mensagemEsperada = "Nome da carta nao pode ser vazio";

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

            var resultado = ObterServico.CriarCarta(cartaTeste);

            var mensagemDeErro = resultado.Errors.FirstOrDefault(e => e.PropertyName == "NomeCarta")?.ErrorMessage;

            Assert.Equal(mensagemEsperada, mensagemDeErro);
        }
        [Fact]
        public void ao_CriarCarta_com_custo_de_mana_convertido_negativo_deve_retornar_Exception()
        {
            const string mensagemEsperada = "Custo de Mana Convertido da Carta deve ser igual ou maior que 0";
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

            var resultado = ObterServico.CriarCarta(cartaTeste);

            var mensagemDeErro = resultado.Errors.FirstOrDefault(e => e.PropertyName == "CustoDeManaConvertidoCarta")?.ErrorMessage;

            Assert.Equal(mensagemEsperada, mensagemDeErro);
        }
        [Fact]
        public void ao_CriarCarta_com_dados_validos_deve_adicionar_ao_banco_de_dados()
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

            ObterServico.CriarCarta(cartaTeste);

            var cartas = ObterServico.ObterTodos();

            Assert.Contains(cartas, c => c == cartaTeste);
        }
    }
}