using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Dominio.Modelos.Enums;

namespace Cod3rsGrowth.Teste.Singleton
{
    public class SingletonTabelas
    {
        private static readonly Lazy<List<Carta>> instanciaCartas = new Lazy<List<Carta>>(() => TabelaCartas.TabelaDeCartas());
        private static readonly Lazy<List<Baralho>> instanciaBaralhos = new Lazy<List<Baralho>>(() => TabelaBaralhos.TabelaDeBaralhos());
        private static readonly Lazy<List<Jogador>> instanciaJogadores = new Lazy<List<Jogador>>(() => TabelaJogadores.TabelaDeJogadores());

        private SingletonTabelas()
        {
        }
        public static List<Carta> InstanciaCartas => instanciaCartas.Value;
        public static List<Baralho> InstanciaBaralhos => instanciaBaralhos.Value;
        public static List<Jogador> InstanciaJogadores => instanciaJogadores.Value;
    }
}