using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Teste.Singleton
{
    public class SingletonTabelasTeste
    {
        private static readonly Lazy<List<Carta>> instanciaCarta = new Lazy<List<Carta>>(() => new List<Carta>() {
                new Carta()
                {
                    Id = 1,
                    NomeCarta = "Ilha",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = "Basic Land",
                    RaridadeCarta = RaridadeEnum.Common,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = ""
                },
                new Carta()
                {
                    Id = 2,
                    NomeCarta = "Pantano",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = "Basic Land",
                    RaridadeCarta = RaridadeEnum.Common,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = ""
                },
                new Carta()
                {
                    Id = 3,
                    NomeCarta = "Floresta",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = "Basic Land",
                    RaridadeCarta = RaridadeEnum.Common,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = ""
                },
                new Carta()
                {
                    Id = 4,
                    NomeCarta = "Planice",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = "Basic Land",
                    RaridadeCarta = RaridadeEnum.Common,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = ""
                },
                new Carta()
                {
                    Id = 5,
                    NomeCarta = "Montanha",
                    CustoDeManaConvertidoCarta = 0,
                    TipoDeCarta = "Basic Land",
                    RaridadeCarta = RaridadeEnum.Common,
                    PrecoCarta = Convert.ToDecimal(0.5),
                    CorCarta = ""
                },
                new Carta()
                {
                    Id = 6,
                    NomeCarta = "Niv-Mizzet, Parum",
                    CustoDeManaConvertidoCarta = 6,
                    TipoDeCarta = "Creature",
                    RaridadeCarta = RaridadeEnum.Rare,
                    PrecoCarta = Convert.ToDecimal(5),
                    CorCarta = "Azul, Vermelho"
                },
                new Carta()
                {
                    Id = 7,
                    NomeCarta = "Ghalta, Fome Primordial",
                    CustoDeManaConvertidoCarta = 12,
                    TipoDeCarta = "Creature",
                    RaridadeCarta = RaridadeEnum.Rare,
                    PrecoCarta = Convert.ToDecimal(5),
                    CorCarta = "Verde"
                }
            });
        private static readonly Lazy<List<Baralho>> instanciaBaralho = new Lazy<List<Baralho>>(() => new List<Baralho>());
        private static readonly Lazy<List<CopiaDeCartasNoBaralho>> instanciaCopiaDeCartasNoBaralho = new Lazy<List<CopiaDeCartasNoBaralho>>(() => new List<CopiaDeCartasNoBaralho>());
        private static readonly Lazy<List<Jogador>> instanciaJogador = new Lazy<List<Jogador>>(() => new List<Jogador>());

        private SingletonTabelasTeste()
        {
        }

        public static List<Carta> InstanciaCarta => instanciaCarta.Value;
        public static List<Baralho> InstanciaBaralho => instanciaBaralho.Value;
        public static List<CopiaDeCartasNoBaralho> InstanciaCopiaDeCartasNoBaralho => instanciaCopiaDeCartasNoBaralho.Value;
        public static List<Jogador> InstanciaJogador => instanciaJogador.Value;
    }
}