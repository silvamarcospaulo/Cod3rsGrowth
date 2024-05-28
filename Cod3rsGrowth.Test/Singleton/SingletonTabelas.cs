using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Test.Singleton
{
    public class SingletonTabelas
    {
        private static readonly Lazy<List<Carta>> instanciaCartas = new(() => new List<Carta>());
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