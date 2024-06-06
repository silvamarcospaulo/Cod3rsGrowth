using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;
using Microsoft.Extensions.DependencyInjection;
using Cod3rsGrowth.Servico.ServicoCarta;

namespace Cod3rsGrowth.Teste.Testes
{
    public class CartaTest : TesteBase
    {
        private readonly IServicoCarta ObterServico;

        public CartaTest()
        {
            ObterServico = ServiceProvider.GetService<IServicoCarta>() ?? throw new Exception("Erro ao obter servico");

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

            listaCartasMock.ForEach(carta => ObterServico.Inserir(carta));
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
            Assert.Throws<Exception>(() => { ObterServico.ObterPorId(idCartaTeste); });
        }
    }
}