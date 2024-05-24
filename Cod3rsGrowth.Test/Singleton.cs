using Cod3rsGrowth.Dominio.Modelos;
using NUnit.Framework.Constraints;

public class Singleton
{
    public sealed class SingletonTabelas
    {
        private static readonly Lazy<List<Carta>> instanciaCartas = new Lazy<List<Carta>>(() => new List<Carta>());
        private static readonly Lazy<List<CopiaDeCartasNoBaralho>> instanciaCopiaDeCartasNoBaralho = new Lazy<List<CopiaDeCartasNoBaralho>>(() => new List<CopiaDeCartasNoBaralho>());
        private static readonly Lazy<List<Baralho>> instanciaBaralhos = new Lazy<List<Baralho>>(() => new List<Baralho>());
        private static readonly Lazy<List<Jogador>> instanciaJogadores = new Lazy<List<Jogador>>(() => new List<Jogador>());

        private SingletonTabelas()
        {
        }
        public static List<Carta> InstanciaCartas => instanciaCartas.Value;
        public static List<CopiaDeCartasNoBaralho> InstanciaListasDeCartas => instanciaCopiaDeCartasNoBaralho.Value;
        public static List<Baralho> InstanciaBaralhos => instanciaBaralhos.Value;
        public static List<Jogador> InstanciaJogadores => instanciaJogadores.Value;
    }
}