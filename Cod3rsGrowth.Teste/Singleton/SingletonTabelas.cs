using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Teste.Singleton
{
    public class SingletonTabelas
    {
        private static readonly Lazy<List<Carta>> instanciaCartas = new Lazy<List<Carta>>(() => new List<Carta>()
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
                NomeCarta = "Anel Solar",
                CustoDeManaConvertidoCarta = 2,
                TipoDeCarta = TipoDeCartaEnum.Artefato,
                RaridadeCarta = RaridadeEnum.Common,
                PrecoCarta = Convert.ToDecimal(0.5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Incolor }
                },
            new Carta()
            {
                IdCarta = 7,
                NomeCarta = "Contra Magica",
                CustoDeManaConvertidoCarta = 2,
                TipoDeCarta = TipoDeCartaEnum.Instantanea,
                RaridadeCarta = RaridadeEnum.Common,
                PrecoCarta = Convert.ToDecimal(0.5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Azul }
                },
            new Carta()
            {
                IdCarta = 8,
                NomeCarta = "Niv-Mizzet, Parum",
                CustoDeManaConvertidoCarta = 6,
                TipoDeCarta = TipoDeCartaEnum.Criatura,
                RaridadeCarta = RaridadeEnum.Rare,
                PrecoCarta = Convert.ToDecimal(5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Azul, CoresEnum.Vermelho }
            },
            new Carta()
            {
                IdCarta = 9,
                NomeCarta = "Erebos, Coração SOmbrio",
                CustoDeManaConvertidoCarta = 4,
                TipoDeCarta = TipoDeCartaEnum.Criatura,
                RaridadeCarta = RaridadeEnum.Mythic,
                PrecoCarta = Convert.ToDecimal(7.5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Preto }
            },
            new Carta()
            {
                IdCarta = 10,
                NomeCarta = "Ghalta, Fome Primordial",
                CustoDeManaConvertidoCarta = 12,
                TipoDeCarta = TipoDeCartaEnum.Criatura,
                RaridadeCarta = RaridadeEnum.Rare,
                PrecoCarta = Convert.ToDecimal(5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Vermelho }
            },
            new Carta()
            {
                IdCarta = 11,
                NomeCarta = "Ruric Thar, o Imbatível",
                CustoDeManaConvertidoCarta = 6,
                TipoDeCarta = TipoDeCartaEnum.Criatura,
                RaridadeCarta = RaridadeEnum.Rare,
                PrecoCarta = Convert.ToDecimal(5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Vermelho, CoresEnum.Azul }
            },
            new Carta()
            {
                IdCarta = 12,
                NomeCarta = "Teysa Karlov",
                CustoDeManaConvertidoCarta = 4,
                TipoDeCarta = TipoDeCartaEnum.Criatura,
                RaridadeCarta = RaridadeEnum.Rare,
                PrecoCarta = Convert.ToDecimal(5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Preto, CoresEnum.Branco }
            },
            new Carta()
            {
                IdCarta = 13,
                NomeCarta = "Teysa Karlov",
                CustoDeManaConvertidoCarta = 4,
                TipoDeCarta = TipoDeCartaEnum.Criatura,
                RaridadeCarta = RaridadeEnum.Rare,
                PrecoCarta = Convert.ToDecimal(5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Preto, CoresEnum.Branco }
            },
            new Carta()
            {
                IdCarta = 14,
                NomeCarta = "Niv-Mizzet, Supremo",
                CustoDeManaConvertidoCarta = 5,
                TipoDeCarta = TipoDeCartaEnum.Criatura,
                RaridadeCarta = RaridadeEnum.Rare,
                PrecoCarta = Convert.ToDecimal(5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Azul, CoresEnum.Verde, CoresEnum.Vermelho, CoresEnum.Preto, CoresEnum.Branco }
            },
            new Carta()
            {
                IdCarta = 15,
                NomeCarta = "Niv-Mizzet Renascido",
                CustoDeManaConvertidoCarta = 5,
                TipoDeCarta = TipoDeCartaEnum.Criatura,
                RaridadeCarta = RaridadeEnum.Mythic,
                PrecoCarta = Convert.ToDecimal(7.5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Azul, CoresEnum.Verde, CoresEnum.Vermelho, CoresEnum.Preto, CoresEnum.Branco }
            },
            new Carta()
            {
                IdCarta = 16,
                NomeCarta = "Niv-Mizzet, Dracogenio",
                CustoDeManaConvertidoCarta = 6,
                TipoDeCarta = TipoDeCartaEnum.Criatura,
                RaridadeCarta = RaridadeEnum.Rare,
                PrecoCarta = Convert.ToDecimal(5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Azul, CoresEnum.Vermelho }
            },
            new Carta()
            {
                IdCarta = 17,
                NomeCarta = "Niv-Mizzet, o Mente de Fogo",
                CustoDeManaConvertidoCarta = 6,
                TipoDeCarta = TipoDeCartaEnum.Criatura,
                RaridadeCarta = RaridadeEnum.Rare,
                PrecoCarta = Convert.ToDecimal(5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Azul, CoresEnum.Vermelho }
            },
            new Carta()
            {
                IdCarta = 18,
                NomeCarta = "Niv-Mizzet, Pacto das Guildas",
                CustoDeManaConvertidoCarta = 5,
                TipoDeCarta = TipoDeCartaEnum.Criatura,
                RaridadeCarta = RaridadeEnum.Rare,
                PrecoCarta = Convert.ToDecimal(5),
                CorCarta = new List<CoresEnum>() { CoresEnum.Azul, CoresEnum.Verde, CoresEnum.Vermelho, CoresEnum.Preto, CoresEnum.Branco }
            }
        });
        private static readonly Lazy<List<CopiaDeCartasNoBaralho>> instanciaCopiaDeCartasNoBaralho = new (() => new List<CopiaDeCartasNoBaralho>());
        private static readonly Lazy<List<Baralho>> instanciaBaralhos = new (() => new List<Baralho>());
        private static readonly Lazy<List<Jogador>> instanciaJogadores = new (() => new List<Jogador>());

        private SingletonTabelas()
        {
        }
        public static List<Carta> InstanciaCartas => instanciaCartas.Value;
        public static List<CopiaDeCartasNoBaralho> InstanciaListasDeCartas => instanciaCopiaDeCartasNoBaralho.Value;
        public static List<Baralho> InstanciaBaralhos => instanciaBaralhos.Value;
        public static List<Jogador> InstanciaJogadores => instanciaJogadores.Value;
    }
}