using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Teste.Singleton
{
    public class SingletonTabelasTeste
    {
        private static readonly Lazy<List<Carta>> instanciaCartas = new Lazy<List<Carta>>(() => new List<Carta>());
        private static readonly Lazy<List<CorCarta>> instanciaCorCarta = new Lazy<List<CorCarta>>(() => new List<CorCarta>());
        private static readonly Lazy<List<Baralho>> instanciaBaralhos = new Lazy<List<Baralho>>(() => new List<Baralho>());
        private static readonly Lazy<List<CopiaDeCartasNoBaralho>> instanciaCopiaDeCartasNoBaralho = new Lazy<List<CopiaDeCartasNoBaralho>>(() => new List<CopiaDeCartasNoBaralho>());
        private static readonly Lazy<List<CorBaralho>> instanciaCorBaralho = new Lazy<List<CorBaralho>>(() => new List<CorBaralho>());
        private static readonly Lazy<List<Jogador>> instanciaJogadores = new Lazy<List<Jogador>>(() => new List<Jogador>());

        private SingletonTabelasTeste()
        {
        }
        public static List<Carta> InstanciaCartas => instanciaCartas.Value;
        public static List<CorCarta> InstanciaCorCarta => instanciaCorCarta.Value;
        public static List<Baralho> InstanciaBaralhos => instanciaBaralhos.Value;
        public static List<CopiaDeCartasNoBaralho> InstanciaCopiaDeCartasNoBaralho => instanciaCopiaDeCartasNoBaralho.Value;
        public static List<CorBaralho> InstanciaCorBaralho => instanciaCorBaralho.Value;
        public static List<Jogador> InstanciaJogadores => instanciaJogadores.Value;
    }
}