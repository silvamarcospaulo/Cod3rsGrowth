using Cod3rsGrowth.Dominio.Modelos.Enums;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Infra.Repository.RepositoryCarta;
using Microsoft.Extensions.DependencyInjection;

namespace Cod3rsGrowth.Teste.Testes
{
    public class CartaTest : TesteBase
    {
        private readonly ICartaRepository ObterServico;

        public CartaTest()
        {
            ObterServico = ServiceProvider.GetService<ICartaRepository>() ?? throw new Exception("Erro ao obter servico");
            IniciarListaMock();
        }

        public void IniciarListaMock()
        {
            List<Carta> listaCartasMock = new List<Carta>()
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

            listaCartasMock.ForEach(carta => ObterServico.Inserir(carta));
        }

        [Fact]
        public void verifica_se_a_lista_esta_vazia()
        {
            var cartas = ObterServico.ObterTodos();

            Assert.NotEmpty(cartas);
        }

        [Fact]
        public void verifica_se_o_metodo_retorna_todas_as_cartas()
        {
            List<Carta> listaDeCartas = new()
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

            var cartas = ObterServico.ObterTodos();

            Assert.Equivalent(listaDeCartas[0], cartas[0]);
            Assert.Equivalent(listaDeCartas[1], cartas[1]);
            Assert.Equivalent(listaDeCartas[2], cartas[2]);
            Assert.Equivalent(listaDeCartas[3], cartas[3]);
            Assert.Equivalent(listaDeCartas[4], cartas[4]);
            Assert.Equivalent(listaDeCartas[5], cartas[5]);
            Assert.Equivalent(listaDeCartas[6], cartas[6]);
        }
    }
}