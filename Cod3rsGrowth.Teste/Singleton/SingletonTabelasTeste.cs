using Cod3rsGrowth.Dominio.Modelos;

namespace Cod3rsGrowth.Teste.Singleton
{
    public class SingletonTabelasTeste
    {
        private static readonly Lazy<List<Carta>> instanciaCarta = new Lazy<List<Carta>>(() => new List<Carta>());
        private static readonly Lazy<List<CorCarta>> instanciaCorCarta = new Lazy<List<CorCarta>>(() => new List<CorCarta>());
        private static readonly Lazy<List<Baralho>> instanciaBaralho = new Lazy<List<Baralho>>(() => new List<Baralho>());
        private static readonly Lazy<List<CopiaDeCartasNoBaralho>> instanciaCopiaDeCartasNoBaralho = new Lazy<List<CopiaDeCartasNoBaralho>>(() => new List<CopiaDeCartasNoBaralho>());
        private static readonly Lazy<List<CorBaralho>> instanciaCorBaralho = new Lazy<List<CorBaralho>>(() => new List<CorBaralho>());
        private static readonly Lazy<List<Jogador>> instanciaJogador = new Lazy<List<Jogador>>(() => new List<Jogador>());

        private SingletonTabelasTeste()
        {
        }

        public static List<Carta> InstanciaCarta => instanciaCarta.Value;
        public static List<CorCarta> InstanciaCorCarta => instanciaCorCarta.Value;
        public static List<Baralho> InstanciaBaralho => instanciaBaralho.Value;
        public static List<CopiaDeCartasNoBaralho> InstanciaCopiaDeCartasNoBaralho => instanciaCopiaDeCartasNoBaralho.Value;
        public static List<CorBaralho> InstanciaCorBaralho => instanciaCorBaralho.Value;
        public static List<Jogador> InstanciaJogador => instanciaJogador.Value;
    }
}